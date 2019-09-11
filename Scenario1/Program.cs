using System;
using System.Text.Json;

namespace Scenario1
{
    class Program
    {
        static void Main(string[] args)
        {
            string employee = GetEmployee();
            Console.WriteLine(employee);
        }

        /* TODO: 
         1) Create an in-memory Document Object Model (DOM) that represents the following JSON:
            {
                "name": "John Smith",
                "is manager": true, 
                "reporting FTE employees ids": [ 1234, 54678, 90, 123, 56789 ],
                "reporting intern employees ids" : [],
                "direct supervisor" : null,
                "address": 
                {
                    "address line 1": "One Microsoft Way",
                    "city": "Redmond",
                    "zip code": 98052,
                    "state": "WA"  
                }
            }
         2) Return it as a string. */
        private static string GetEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
