using System;
using CommandLine;

namespace CommandLineParserDemo
{
    class Program
    {
        public class Options
        {
            [Option("use-tls", Default = false, HelpText = "Starts server using Transport Layer Security, TLS")]
            public bool UseTls { get; set; }
        }

        static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                Console.WriteLine($"Use TLS flagg was set to: {options.UseTls}");
            }) // options is an instance of Options type
            .WithNotParsed(errors =>
            {
                Console.WriteLine("Errors occurred while parsing arguments");
            }); // errors is a sequence of type IEnumerable<Error>
        }
    }
}
