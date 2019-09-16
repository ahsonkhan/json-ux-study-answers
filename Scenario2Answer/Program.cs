using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Linq;

namespace Scenario2
{
    class Program
    {
        /* TODO: Return a string containing properties from a given input JSON
                 file with the following modifications:
         1) Multiply all existing numbers by 2.
         2) Insert a property "input_frequency" with value 6.

           DO NOT use a serializer, but parsing is OK. */
        private static string ModifyJson(string configuration)
        {
            JObject config = JObject.Parse(configuration);
            
            foreach(KeyValuePair<string, JNode> property in config)
            {
                if (property.Value is JNumber number)
                {
                    number.SetDouble(number.GetDouble() * 2);
                }
            }

            config.Add("input_frequency", 6);

            return config.ToString();
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
