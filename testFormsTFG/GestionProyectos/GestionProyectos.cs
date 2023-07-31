﻿using Aspose.Email.Clients.Google;
using Aspose.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Google.Apis.Calendar.v3.Data;
using AppGestionTFG;
using System.Web.UI.WebControls.WebParts;

namespace testFormsTFG.GestionProyectos
{
    public partial class GestionProyectos : Form
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "AppGestionTFG";

        FuncionesBD fbd = new FuncionesBD();

        DataTable datosPiezas = new DataTable();
        DataTable datosProy = new DataTable();

        public GestionProyectos()
        {
            InitializeComponent();
            obtenerEventos();
        }

        private void GestionProyectos_Load(object sender, EventArgs e)
        {
            this.cbProys.Items.Clear();
            datosProy = fbd.obtenerProys();
            foreach (DataRow row in datosProy.Rows)
            {
                this.cbProys.Items.Add(row[0].ToString() + "#" + row[1].ToString());
            }
            this.cbProys.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoogleUser User = new GoogleUser("angelgarcia1311", "angelgarcia1311@gmail.com", "Googleaccount113@", "clientId", "client secret");
            string accessToken;
            string refreshToken;

            // Get access token
            GoogleOAuthHelper.GetAccessToken(User, out accessToken, out refreshToken);

            // Get instance of Gmail client
            using (IGmailClient client = GmailClient.GetInstance(accessToken, User.EMail))
            {
                // Insert and get calendar
                Aspose.Email.Clients.Google.Calendar calendar = new Aspose.Email.Clients.Google.Calendar("summary - " + Guid.NewGuid().ToString(), null, null, "America/Los_Angeles");

                // Insert calendar and retrieve id
                string id = client.CreateCalendar(calendar);
                Aspose.Email.Clients.Google.Calendar cal = client.FetchCalendar(id);
            }
        }

        private void obtenerEventos()
        {
            UserCredential credential;


            using (var stream =
                new FileStream("credenciales.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Archivo de credenciales guardado en: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now.AddDays(-1);
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 5;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            test.Text = "";
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    DateTime dateTime;
                    if (eventItem.Start.DateTime != null)
                    {
                        dateTime = (DateTime)eventItem.Start.DateTime;
                        test.Text += eventItem.Summary + " - " + dateTime.Date.ToShortDateString() + Environment.NewLine;
                    }
                    else if (eventItem.Start != null)
                    {
                        dateTime = DateTime.ParseExact(eventItem.Start.Date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                        test.Text += eventItem.Summary + " - " + dateTime.ToString("dd-MM-yyyy");
                    }
                }
            }
            else
            {
                test.Text = "No hay proyectos";
            }
            Console.Read();
        }

        private void getEvents_Tick(object sender, EventArgs e)
        {
            obtenerEventos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCredential credential;


            using (var stream =
                new FileStream("credenciales.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }



            Event ev = new Event();
            EventDateTime start = new EventDateTime();
            EventDateTime end = new EventDateTime();
            start.Date = "2023-07-27";
            end.Date = "2023-07-27";


            ev.Start = start;
            ev.End = end;
            ev.Summary = "EVENTO NUEVO";
            ev.Description = "Desc";

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var calendarId = "primary";
            Event recurringEvent = service.Events.Insert(ev, calendarId).Execute();

            //EventsResource.InsertRequest(service, ev, "primary");
        }

        private void cbProys_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelNom.Text = datosProy.Rows[this.cbProys.SelectedIndex][1].ToString();
            this.labelDesc.Text = datosProy.Rows[this.cbProys.SelectedIndex][2].ToString();
            this.labelCliente.Text = datosProy.Rows[this.cbProys.SelectedIndex][5].ToString();
            this.labelFIni.Text = datosProy.Rows[this.cbProys.SelectedIndex][3].ToString();
            poblarTreeView();
        }

        private void poblarTreeView()
        {
            Cursor = Cursors.WaitCursor;
            this.treeViewProys.Nodes.Clear();
            string id_proy = this.cbProys.SelectedItem.ToString().Substring(0, this.cbProys.SelectedItem.ToString().IndexOf('#'));
            this.datosPiezas = fbd.obtenerEstructs(id_proy);

            poblarNodo(null, "0", false);
            Cursor = Cursors.Default;

        }

        private void poblarNodo(TreeNode nodoPadre, string codpadre, bool altern)
        {
            TreeNode nodoHijo;

            foreach (DataRow dr in datosPiezas.Select("[CODIGO_PADRE]='" + codpadre + "'"))
            {
                TreeNode t = new TreeNode();

                if (altern)
                {
                    t.BackColor = Color.LightGray;
                }

                t.Text = dr["CODIGO"].ToString() + " - " + dr["DESCRIPCION"].ToString();
                t.Name = dr["CODIGO"].ToString();
                t.Tag = datosPiezas.Rows.IndexOf(dr);
                if (nodoPadre == null)
                {
                    this.treeViewProys.Nodes.Add(t);
                    nodoHijo = t;
                }
                else
                {
                    nodoPadre.Nodes.Add(t);
                    nodoHijo = t;
                }

                poblarNodo(nodoHijo, dr["CODIGO"].ToString(), !altern);
            }
        }
    }
}
