using System;
using System.Text.Json;
using System.Text.Json.Linq;

namespace Scenario1
{
    class Program
    {
        /* TODO:
         1) Programmatically create the JSON tree structure from scratch, also known as the
            DOM, for the following JSON text. Look for approaches that are similar
            to how you would construct XML elements in C#, from scratch.

            {
                "name": "John Smith",
                "is manager": true,
                "employee ids": [ 1234, 54678, 90 ],
                "direct supervisor" : null,
                "address":
                {
                    "address line 1": "One Microsoft Way",
                    "zip code": 98052
                }
            }

         2) Transform the DOM representation as JSON text and return that.

        DO NOT use parsing or serialization. */
        private static string GetEmployee()
        {
            var employee = new JObject()
            {
                { "name", "John Smith"},
                { "is manager", true},
                { "employee ids", new JArray(){ 1234, 54678, 90 } },
                { "direct supervisor", null},
                {
                    "address", new JObject()
                    {
                        { "address line 1", "One Microsoft Way"},
                        { "zip code", 98052 },
                    }
                }
            };

            return employee.ToString();
        }

        // -------------------------------------
        // The code below SHOULD NOT BE modified
        // -------------------------------------

        #region Main
        static void Main(string[] args)
        {
            string employee = GetEmployee();
            Console.WriteLine(employee);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        #endregion
    }
}
