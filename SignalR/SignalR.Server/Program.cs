using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using SignalR.Server;

namespace SignalR.Client
{
    public class Program
    {
        private const string Url = "http://localhost:9080";

        private static void Main(string[] args)
        {
            Console.WriteLine("Server started");

            using (WebApp.Start(Url, Configuration))
            {
                Console.WriteLine($"Server running on {Url}");
                Console.WriteLine("Press any key to send a message to connected clients");
                Console.ReadKey();

                // Send message to all connected clients
                var context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
                context.Clients.All.addMessage("Server", "Hello from server");
           
                Console.ReadLine();
            }
        }

        public static void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}