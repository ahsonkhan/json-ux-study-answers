using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Scenario4
{
    class Program
    {
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
            Console.ReadLine();
        }

        // TODO 1) Serialize the "Song" object to a JSON representation where the Genre property is written as a string.
        // 2) Ensure the Genre property is written as a string. For example, {"Title":"Three Little Birds","Artist":"Bob Marley","Genre":"Reggae"}
        private static string Serialize(Song song)
        {
            // <Add/modify code here>
            return "";
        }
    }

    public enum Genre { Classical, Rap, Soul, PopRock, Reggae };

    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }
    }
}
