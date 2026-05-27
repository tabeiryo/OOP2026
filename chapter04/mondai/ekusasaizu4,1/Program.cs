
namespace ekusasaizu4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = [
              "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs)

        {
             int i=0;
            while (true) {
                var isExists = false;
                 isExists = langs.Any(s => s.ToString().Contains('S'));

                if (isExists == true)
                {
                    Console.WriteLine(langs[i]);
                }
                i++;
                if (langs[i]=="Go")
                {
                    break;
                }
            } 
            //foreach (var i in gg)
            //{
             //   Console.WriteLine(i);
            //}
        }

        private static void Exercise2(List<string> langs)
        {
            IEnumerable<string> lang = langs.Where(s => s.ToString().Contains('S'));
            foreach (var i in lang)
            {
                Console.WriteLine(i);
            }
        }

        private static void Exercise3(List<string> langs)
        {
            var lang = langs.FindAll(s => s.Length == 10);
            foreach (var i in lang)
            {
                if (i is null)
                {
                    Console.WriteLine("unknown");
                }
                Console.WriteLine(i );
            }
            }
            }
    }
