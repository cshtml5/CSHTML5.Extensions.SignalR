using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SilverlightSignalRTest.Web
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.received(name, message);
        }
    }
}