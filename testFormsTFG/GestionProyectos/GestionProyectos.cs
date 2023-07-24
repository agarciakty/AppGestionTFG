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

namespace testFormsTFG.GestionProyectos
{
    public partial class GestionProyectos : Form
    {
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "AppGestionTFG";

        public GestionProyectos()
        {
            InitializeComponent();
            googleApi();
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

        private void googleApi()
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

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 5;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    test.Text += eventItem.Summary + Environment.NewLine;
                }
            }
            else
            {
                test.Text = "No upcoming events found.";
            }
            Console.Read();
        }

        private void getEvents_Tick(object sender, EventArgs e)
        {
            googleApi();
        }
    }
}
