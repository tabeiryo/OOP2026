
namespace exisis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };
            // 3.2.1
            Exercise1(cities);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2(cities);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise3(cities);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise4(cities);
        }

        private static void Exercise1(List<string> cities)
        {
       
            var name = Console.ReadLine();
            int index = cities.FindIndex(s => s == name);
            Console.WriteLine(index);
            
        }

        private static void Exercise2(List<string> cities)
        {
            var count = cities.Count( n => n.ToString().Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise3(List<string> cities)
        {
            IEnumerable<string> query = cities.Where(s => s.ToString().Contains('o'));
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
        }

        private static void Exercise4(List<string> cities)
        {
            var query = cities.Where(s => s[0] == 'B').ToList().Select(s => s.Length);

            foreach (var i in query) 
                { Console.WriteLine(i); }
            

        }
    }
}
//IEnumerable<int>