using System;

namespace SystemCommandLineDemo
{
    class Program
    {
        // This example uses the System.CommandLine and System.ComandLine.DragonFruit packages
        // https://github.com/dotnet/command-line-api
        
        /// <param name="useTls">Starts server using Transport Layer Security, TLS</param>
        static void Main(bool useTls)
        {
            Console.WriteLine($"Use TLS flagg was set to: {useTls}");
        }
    }
}
