using System;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Transports;

namespace SignalR.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client started");
            
            using (var connection = new HubConnection("http://localhost:9080"))
            {
                var hubProxy = connection.CreateHubProxy("MyHub");

                // Specify action to execute when a message is received
                hubProxy.On<string, string>("addMessage", (name, message) => Console.WriteLine(message));

                // Start listening
                connection.Start(new LongPollingTransport()).GetAwaiter().GetResult();

                Console.WriteLine("Client connected. Press any key to send a message");
                Console.ReadKey();

                // Send a message to server / other clients
                hubProxy.Invoke("addMessage", "Guest", "Hello World").Wait();

                Console.WriteLine("Message send. Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
