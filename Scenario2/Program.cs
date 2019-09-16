using System;
using System.IO;
using System.Text.Json;

namespace Scenario2
{
    class Program
    {
        /* TODO: Return a string containing properties from a given input JSON
                 file with following modifications:
         1) Multiply all existing numbers by 2.
         2) Insert a property "input_frequency" with value 6.

           DO NOT use a serializer, but parsing is OK. */
        private static string ModifyJson(string configuration)
        {
            // TODO: Add/modify code here
            throw new NotImplementedException();
        }

        // -------------------------------------
        // The code below SHOULD NOT BE modified
        // -------------------------------------

        #region Main
        static void Main(string[] args)
        {
            string configuration = File.ReadAllText("input.json");
            string doubledProperties = ModifyJson(configuration);
            Console.WriteLine(doubledProperties);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        #endregion
    }
}
