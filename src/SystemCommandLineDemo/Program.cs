using System;

namespace SystemCommandLineDemo
{
    class Program
    {
        // This example uses the System.CommandLine and System.ComandLine.DragonFruit packages
        // https://github.com/dotnet/command-line-api
        
        /// <summary>
        /// Sample application, parsing arguments using DragonFruit
        /// </summary>
        /// <param name="useTls">Starts server using Transport Layer Security, TLS</param>
        /// <param name="port">Set the port for the server to listen to, default = 80</param>
        static void Main(bool useTls, int port = 80)
        {
            Console.WriteLine($"Use TLS flagg was set to: {useTls} and port: {port} {Boolean.FalseString}");
        }
    }
}
