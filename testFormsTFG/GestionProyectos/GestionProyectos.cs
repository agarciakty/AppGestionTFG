using Aspose.Email.Clients.Google;
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
using DocumentFormat.OpenXml.EMMA;

namespace testFormsTFG.GestionProyectos
{
    public partial class GestionProyectos : Form
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "AppGestionTFG";

        FuncionesBD fbd = new FuncionesBD();

        DataTable datosPiezas = new DataTable();
        DataTable datosProy = new DataTable();

        string id_proy = "0";
        string id_padre = "0";

        DataTable operarios = new DataTable();
        DataTable operaciones = new DataTable();
        DataTable MParticulos = new DataTable();

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
            this.labelFIni.Text = datosProy.Rows[this.cbProys.SelectedIndex][3].ToString().Substring(0, datosProy.Rows[this.cbProys.SelectedIndex][3].ToString().IndexOf(' '));
            poblarTreeView();
        }

        private void poblarTreeView()
        {
            Cursor = Cursors.WaitCursor;
            this.treeViewProys.Nodes.Clear();
            id_proy = this.cbProys.SelectedItem.ToString().Substring(0, this.cbProys.SelectedItem.ToString().IndexOf('#'));
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


        private void treeViewProys_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {

                contextMenuStrip1.Show(Cursor.Position);
                treeViewProys.SelectedNode = treeViewProys.GetNodeAt(e.X, e.Y);

                //pictureBox1.ContextMenu = cm;
            }
        }

        private void treeViewProys_DoubleClick(object sender, EventArgs e)
        {
            this.panel2.Visible = true;

            this.labelNomPieza.Text = this.treeViewProys.SelectedNode.Name.ToString();
            this.labelDescPieza.Text = this.treeViewProys.SelectedNode.Text.ToString();

            if (this.treeViewProys.SelectedNode.Nodes.Count > 0)
            {
                this.labelNumCompo.Text = "(" + this.treeViewProys.SelectedNode.Nodes.Count.ToString() + ")";
                this.panel2.Size = new Size(659, 252);
                this.dgvCompo.Visible = false;
            }
            else
            {
                
                this.dgvCompo.Visible = true;
                this.panel2.Size = new Size(659, 463);
                this.dgvCompo.DataSource = fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy);
                this.labelNumCompo.Text = "(" + this.dgvCompo.Rows.Count + ", ARTÍCULOS MATERIA PRIMA)";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se va a eliminar el proyecto actual, ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnEliminarOp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se van a eliminar " + dgvCompo.SelectedRows.Count + " operaciones en la pieza " + labelNomPieza.Text + ", ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvCompo.SelectedRows)
                    {
                        fbd.eliminarOperacion(labelNomPieza.Text, row.Cells[0].Value.ToString(), id_proy, row.Cells[2].Value.ToString());
                    }

                    this.dgvCompo.DataSource = fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy);
                    MessageBox.Show("Operaciones eliminadas", "BORRADO COMPLETO");
                    break;
                case DialogResult.No:
                    break;
            }

            
        }

        private void btnAñadirOp_Click(object sender, EventArgs e)
        {
            this.panelOps.Visible = true;
            this.panel2.Visible = false;
            this.cbMPOp.Items.Clear();
            this.cbOperaciones.Items.Clear();
            this.cbOperario.Items.Clear();

            operaciones = fbd.obtenerOperaciones();
            operarios = fbd.obtenerPersonal();
            MParticulos = fbd.getArticulos();

            foreach (DataRow row in operaciones.Rows)
            {
                this.cbOperaciones.Items.Add(row[1].ToString());
            }

            this.cbOperaciones.SelectedIndex = 0;

            foreach (DataRow row2 in MParticulos.Rows)
            {
                this.cbMPOp.Items.Add(row2[1].ToString());
            }
            this.cbMPOp.SelectedIndex = 0;

            foreach(DataRow row3 in operarios.Rows)
            {
                this.cbOperario.Items.Add(row3[1].ToString() + "( " + row3[2].ToString() + " )");
            }
            this.cbOperario.SelectedIndex = 0;


        }

        private void btnCerrarPanelOps_Click(object sender, EventArgs e)
        {
            this.panelOps.Visible = false;
            this.panel2.Visible = true;
        }

        private void cbMPOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDenomiOp.Text = this.MParticulos.Rows[this.cbMPOp.SelectedIndex][2].ToString();
        }

        private void btnAceptarOp_Click(object sender, EventArgs e)
        {
            this.panelOps.Visible = false;
            this.panel2.Visible = true;

            fbd.nuevaOperacion(this.labelNomPieza.Text, this.cbMPOp.SelectedItem.ToString(), id_proy, operarios.Rows[this.cbOperario.SelectedIndex]["DNI"].ToString(), (this.cbOperaciones.SelectedIndex+1).ToString());

            this.dgvCompo.DataSource = fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy);
            MessageBox.Show("Nueva operación añadida", "INSERCIÓN COMPLETA");

        }

        private void cbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbOperario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nUEVOCOMPONENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;

            if (id_padre == "0")
            {
                this.tbCodigoPieza.Text = "P" + id_proy + "-" + (this.treeViewProys.Nodes.Count + 1);
            }
            else
            {
                this.tbCodigoPieza.Text = this.treeViewProys.SelectedNode.Name.ToString() + "." + (this.treeViewProys.SelectedNode.Nodes.Count + 1);
            }

        }

        private void eLIMNARCOMPONENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if  (treeViewProys.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("El nodo seleccionado no se puede eliminar porque contiene hijos", "ATENCIÓN");
            }
            else
            {
                foreach( DataRow row in fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy).Rows)
                {
                    //AQUÍ LO SUYO ES PONER EL ON DELETE CASCADE PARA NO HACERLO POR CÓDIGO
                    //fbd.eliminarOperacion()
                }

                DialogResult dr = MessageBox.Show("Se va a eliminar la pieza " + this.treeViewProys.SelectedNode.Name.ToString() + ", ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:

                        string padre = "0";
                        if (treeViewProys.SelectedNode.Parent != null)
                        {
                            padre = treeViewProys.SelectedNode.Parent.Name.ToString();
                        }
                        fbd.eliminarPieza(this.treeViewProys.SelectedNode.Name.ToString(), id_proy,padre);
                        this.treeViewProys.SelectedNode.Remove();
                        MessageBox.Show("Operaciones eliminadas", "BORRADO COMPLETO");
                        break;
                    case DialogResult.No:
                        break;
                }

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void treeViewProys_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                contextMenuStrip1.Show(Cursor.Position);

                TreeNode node = treeViewProys.GetNodeAt(e.X, e.Y);

                if (node == null)
                {
                    id_padre = "0";
                }
                else
                {
                    id_padre = node.Name.ToString();
                }

                //pictureBox1.ContextMenu = cm;
            }
        }

        private void btnAceptarNuevaPieza_Click(object sender, EventArgs e)
        {
            fbd.nuevaPieza(this.tbCodigoPieza.Text, this.tbDescPieza.Text, id_proy, id_padre);
            
            this.treeViewProys.Nodes.Clear();
            poblarTreeView();

            MessageBox.Show("Se ha insertado una nueva pieza para el proyecto " + this.cbProys.Text, "NUEVA PIEZA AÑADIDA");

        }

        private void btnCerrarPanel3_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
        }

        private void treeViewProys_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
