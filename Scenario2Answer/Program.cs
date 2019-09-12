using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Scenario2
{
    class Program
    {
        static void Main(string[] args)
        {
            string configuration = File.ReadAllText("input.json");
            string doubledProperties = DoubleAllProperties(configuration);
            Console.WriteLine(doubledProperties);
        }

        /* TODO: Return a string containing properties from a given config file with following modifications:
         1) Multiply all values by 2.
         2) Insert a property "input_frequency" with value 6.
         3) Make sure the resulting JSON only contains numeric values without dropping any properties. */
        private static string DoubleAllProperties(string configuration)
        {
            var configurationObject = (JsonObject) JsonNode.Parse(configuration, new JsonNodeOptions { DuplicatePropertyNameHandling = DuplicatePropertyNameHandlingStrategy.Ignore });
            
            foreach(KeyValuePair<string, JsonNode> property in configurationObject)
            {
                var jsonNumber = property.Value as JsonNumber;
                if (jsonNumber != null && jsonNumber.TryGetDouble(out double doubleNumber))
                {
                    jsonNumber.SetDouble(doubleNumber * 2);
                }
            }

            configurationObject.Add("input_frequency", 6);

            return configurationObject.ToJsonString();
        }
    }
}
