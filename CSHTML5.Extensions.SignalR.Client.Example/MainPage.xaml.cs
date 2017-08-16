using System;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CSHTML5.Extensions.SignalR.Client.Example
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += UserControl_Loaded;

            // Populate the "Your name" field with a randomly-generated name, for convenience:
            txtName.Text = "User" + (new Random()).Next(1000, 9999);
        }

        HubConnection connection;
        IHubProxy hub;

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Interop.IsRunningInTheSimulator)
            {
                // Specify the URL of the server:
                //string serverUri = new Uri(HtmlPage.Document.DocumentUri.ToString()).ToString();
                string serverUri = new Uri("http://localhost:56581/").ToString();

                // Create a new Connection:
                connection = new HubConnection(serverUri);

                // Create a new Hub:
                hub = await connection.CreateHubProxy("chathub");

                // Listen to the "Received" event:
                hub.On<string, string>("received",
                     (name, message) =>
                     {
                         // Add the message to the output ListBox:
                         Tuple2<string, string> t = new Tuple2<string, string>(name, message);
                         ListBoxWithMessages.Items.Add(t);
                     });

                //connection.StateChanged += connection_StateChanged;
                connection.Start();
            }
            else
            {
                MessageBox.Show("The Simulator does not support running SignalR applications because the current version does not support Ecmascript 6. Please test this application in the browser instead. To do so, wait for the generation to complete, and then click 'Run in browser'.");
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            if (!Interop.IsRunningInTheSimulator)
            {
                // Send the message: 
                hub.Invoke("SendMessage", txtName.Text, txtMessage.Text);
                txtMessage.Text = "";
            }
            else
            {
                MessageBox.Show("The Simulator does not support running SignalR applications because the current version does not support Ecmascript 6. Please test this application in the browser instead. To do so, wait for the generation to complete, and then click 'Run in browser'.");
            }
        }
    }
}
