using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Scenario4
{
    class Program
    {
        // TODO: Serialize the "Song" object to a JSON representation
        //       where instead of a number the property with the Genre
        //       enum is written as a string. So instead of
        //
        //           "Genre": 3
        //
        //       it should be
        //
        //           "Genre": "PopRock"
        //
        private static string Serialize(Song song)
        {
            // TODO: Add/modify code here
            return "";
        }

        // -------------------------------------
        // The code below SHOULD NOT BE modified
        // -------------------------------------

        public enum Genre { Classical, Rap, Soul, PopRock, Reggae };

        public class Song
        {
            public string Title { get; set; }
            public string Artist { get; set; }
            public Genre Genre { get; set; }
        }

        #region Main
        static void Main(string[] args)
        {
            Song song = new Song()
            {
                Title = "Hey Jude",
                Artist = "The Beatles",
                Genre = Genre.PopRock,
            };

            string json = Serialize(song);
            Console.WriteLine(json);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        #endregion
    }
}
