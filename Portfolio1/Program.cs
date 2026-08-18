using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;

namespace Portfolio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration() //setting up Serilog for 1.2
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Starting Portfolio1 Application ;)");

            Console.WriteLine("Hello World! Task 1.1 :)");

            var prog = new { Equation = "1 + 1", Result = "2 = task 1.2 done" }; // setting up newtonsoft.json for 1.2
            string jsonOutput = JsonConvert.SerializeObject(prog, Formatting.Indented);

            Console.WriteLine("\n--- Credit Task 1.2 ---");
            Console.WriteLine(jsonOutput);

            Log.Information("Application finished successfully.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
