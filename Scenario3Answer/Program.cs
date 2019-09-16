using System;
using System.Text.Json;
using System.Text.Json.Linq;

namespace Scenario3
{
    class Program
    {
        /* TODO: 
         1) Modify the given JsonElement by:
            * changing the e-mail property to "annp@mail.com"
            * adding a grade of 55 between 60 and 85 in the grades array.
         2) Return back the modified JSON as an instance of JsonElement. */
        private static JsonElement ModifyStudent(JsonElement student)
        {
            JObject modifiableStudent = (JObject)student.ToJNode();
            modifiableStudent["email"] = "annp@mail.com";
            var gradesArray = (JArray)modifiableStudent["grades"];
            gradesArray.Insert(2, 55);
            return modifiableStudent.AsJsonElement();
        }

        // -------------------------------------
        // The code below SHOULD NOT BE modified
        // -------------------------------------

        private static JsonElement GetStudent()
        {
            string jsonString = @"
{
    ""first name"" : ""Ann"",
    ""last name"" : ""Predictable"",
    ""email"" : ""ann.predictable@mail.com"",
    ""grades"": [70, 60, 85]
}
            ";

            JsonDocument document = JsonDocument.Parse(jsonString);
            return document.RootElement;
        }

        #region Main
        static void Main(string[] args)
        {
            JsonElement student = GetStudent();
            student = ModifyStudent(student);
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        #endregion
    }
}
