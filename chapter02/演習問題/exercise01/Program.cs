using System.Runtime.InteropServices;

namespace exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[] {
                new Song("letitbe", "THEbeetles",243),
                new Song("BREigeoverTrionblidwalre", "simon&Gaffunkei", 293),
                new Song("Gloss Toyo", "Gerpantites", 276),
                new Song("Honstry", "Sliiy deal", 231),
                new Song("I Will Alwersloveyou", "Wilitney hongston", 273),
            };
            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs)
        {
            foreach (var n in songs)
            {

                Console.WriteLine(n.Title + "/" + n.ArtistName + "/" + n.Length / 60 + ":" + n.Length % 60);
            }
        }

        //private static void PrintSongs(object songs)
        //{
        //    foreach (var n in songs)
        //    {

        //    }
        //}
    }
}
