namespace section04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };
            //IEnumerable<string> query = cities.Where(s => s.Length <= 5).Select(s => s.ToLower());
            //foreach (string s in query) { Console.WriteLine(s); }

            var query = cities.Where(s => s.Length <= 5).ToList();
                foreach (var item in query) {
                    Console.WriteLine(item);
                }
                
            
            Console.WriteLine("------------");

            cities[0] = "Osaka";
            foreach (var item in query) { Console.WriteLine(item); }
            {

            }
        }
    }
}
