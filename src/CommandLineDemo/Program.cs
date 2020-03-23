using System;

namespace CommandLineDemo
{
    class Program
    {
        // This example uses a naive manual approach to parsing command line arguments. This is not a recommended solution!
        
        static void Main(string[] args)
        {
            bool useTls = args.Length > 0 && args[0] == "--use-tls";

            Console.WriteLine($"Use TLS flagg was set to: {useTls}");
        }
    }
}
