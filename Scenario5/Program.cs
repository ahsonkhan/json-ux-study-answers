using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Scenario5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account johnAccount = GetAccount();
            Console.WriteLine(SerializeToCustomJson(johnAccount));

            string customJson = GetCustomFormattedAccountJson();
            Account jetAccount = DeserializeFromCustomJson(customJson);
            Console.WriteLine(jetAccount?.Email);
            Console.WriteLine(jetAccount?.CreatedDate);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();
        }

        // The Example Company uses the MM/dd/yyyy format for DateTimeOffset values in their Account models.
        // TODO: 1) Serialize the "account" object to a custom-formatted JSON string and return it.
        private static string SerializeToCustomJson(Account account)
        {
            // <Add/modify code here>
            return "";
        }

        // The Example Company uses the MM/dd/yyyy format for DateTimeOffset values in their Account models.
        // TODO: 2) Deserialize the custom-formatted JSON string as an "account" object and return it.
        private static Account DeserializeFromCustomJson(string json)
        {
            // <Add/modify code here>
            return null;
        }

        private static Account GetAccount()
        {
            // Note: Do NOT modify the Account object creation.
            Account account = new Account
            {
                Email = "john@example.com",
                CreatedDate = DateTimeOffset.Parse("August 31, 2019")
            };

            return account;
        }

        private static string GetCustomFormattedAccountJson()
        {
            // Note: Do NOT modify the Account JSON representation.
            string json = @"{
                ""Email"": ""jet@example.com"",
                ""CreatedDate"": ""08/18/2019""
            }";
            return json;
        }
    }

    public class Account
    {
        public string Email { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
