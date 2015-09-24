using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalR.Server
{
    public class MyHub : Hub
    {
        public void addMessage(string name, string message)
        {
            Console.WriteLine("Server send: " + name + " - " + message);
            Clients.All.addMessage(name, message);
        }

        public override Task OnConnected()
        {
            Console.WriteLine("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            Console.WriteLine("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}