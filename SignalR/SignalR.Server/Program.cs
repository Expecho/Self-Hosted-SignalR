using System;
using Microsoft.Owin.Hosting;
using Owin;

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
                Console.WriteLine("Server running on {0}", Url);
                Console.ReadLine();
            }
        }

        public static void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}