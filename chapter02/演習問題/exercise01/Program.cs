using System.Globalization;
using System.Runtime.InteropServices;

namespace exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            var songs = new Song[i];
            var str1 = "end";
            while (true)
            {
                Console.WriteLine(i+"曲目");
                Console.WriteLine();
                Console.Write("曲名を入力");
                string Title = Console.ReadLine(); //nyuuryoku
                if (string.Compare(Title, str1,ignoreCase:true) == 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }
                Console.Write("名前を入力");
                string ArtistName = Console.ReadLine(); //nyuuryoku
                if (string.Compare(ArtistName, str1, ignoreCase: true) == 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }
                Console.Write("時間を入力");
                string time = Console.ReadLine(); //nyuuryoku
                if (string.Compare(time, str1, ignoreCase: true) == 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }
                int length = int.Parse(time);
                songs[i] = (Title, ArtistName, length);
                i++;
            }


            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs)
        {
            foreach (var n in songs)
            {
                int j = 1;
                Console.WriteLine("曲"+j+":"+n.Title + "/" + n.ArtistName + "/" + n.Length / 60 + ":" + n.Length % 60);
            }
        }

        
    }
}
