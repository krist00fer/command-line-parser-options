using System;

namespace CommandLineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useTls = args.Length > 0 && args[0] == "--use-tls";

            Console.WriteLine($"Use TLS flagg was set to: {useTls}");
        }
    }
}
