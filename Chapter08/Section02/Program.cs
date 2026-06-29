namespace Section02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Sample.txt");
            var we = new WordsExtractor(lines);
            foreach (var line in we.Extract()) { Console.WriteLine(line); }
        }
    }

    
}
