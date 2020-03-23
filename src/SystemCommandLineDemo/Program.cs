using System;

namespace SystemCommandLineDemo
{
    class Program
    {
        /// <param name="useTls">Starts server using Transport Layer Security, TLS</param>
        static void Main(bool useTls)
        {
            Console.WriteLine($"Use TLS flagg was set to: {useTls}");
        }
    }
}
