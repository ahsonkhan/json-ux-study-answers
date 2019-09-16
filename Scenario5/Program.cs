using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Scenario5
{
    class Program
    {
        // We want to serialize the DateTimeOffset using a specific format,
        // namely as "MM/dd/yyyy".
        //
        // TODO: Serialize the given account to a custom-formatted JSON string
        //       and return it.
        private static string SerializeToCustomJson(Account account)
        {
            // TODO: Add/modify code here
            return "";
        }

        // The data we're given uses the "MM/dd/yyyy" format for DateTimeOffset
        // values.
        //
        // TODO: Deserialize the custom-formatted JSON string as an Account object
        //       and return it.
        private static Account DeserializeFromCustomJson(string json)
        {
            // TODO: Add/modify code here
            return null;
        }

        // -------------------------------------
        // The code below SHOULD NOT BE modified
        // -------------------------------------

        public class Account
        {
            public string Email { get; set; }
            public DateTimeOffset CreatedDate { get; set; }
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

        #region Main
        static void Main(string[] args)
        {
            Account johnAccount = GetAccount();
            Console.WriteLine(SerializeToCustomJson(johnAccount));

            string customJson = GetCustomFormattedAccountJson();
            Account jetAccount = DeserializeFromCustomJson(customJson);
            Console.WriteLine(jetAccount?.Email);
            Console.WriteLine(jetAccount?.CreatedDate);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        #endregion
    }
}
