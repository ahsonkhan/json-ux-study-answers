using System;
using System.Text.Json;

namespace Scenario3
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonElement student = GetStudent();
            student = ModifyStudent(student);
            Console.WriteLine(student.ToString());
        }

        /* TODO: 
         1) Modify the given JsonElement by:
            * changing e-mail property to "annp@mail.com"
            * adding a grade 55 between 60 and 85 in the grades array.
         2) Return back the modified JSON as an instance of JsonElement.*/    
        private static JsonElement ModifyStudent(JsonElement student)
        {
            throw new NotImplementedException();
        }

        private static JsonElement GetStudent()
        {
            string jsonString = @"
            {
                ""first name"" : ""Ann"",
                ""last name"" : ""Predictable"",
                ""email"" : ""ann.predictable@mail.com"",
                ""grades"": [70, 60, 85]
            }";
            
            JsonDocument document = JsonDocument.Parse(jsonString);
            return document.RootElement;
        }
    }
}
