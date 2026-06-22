
using static System.Reflection.Metadata.BlobBuilder;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [5,10,17,9,3,21,10,40,21,3,35];
            　

            Console.WriteLine("7.1.1");
            Exercise1(numbers);

            Console.WriteLine("7.1.2");
            Exercise2(numbers);

            Console.WriteLine("7.1.3");
            Exercise3(numbers);

            Console.WriteLine("7.1.4");
            Exercise4(numbers);

            Console.WriteLine("7.1.5");
            Exercise5(numbers);
        }

        private static void Exercise1(int[] numbers)
        {
            var maxnum = numbers.Max(x => x);
            Console.WriteLine(maxnum);
        }

        private static void Exercise2(int[] numbers)
        {
            for (int i = numbers.Length - 2; i < numbers.Length; i++ )
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static void Exercise3(int[] numbers)
        {
            
           IEnumerable<string> query =numbers.Select(x => x.ToString());
            foreach (var item in query)
            {
                if (item.Length == 2||item.Length==1)
                {
                    if (item.Length == 2)
                    {
                        string zero = "0";
                        string zerostr = zero + item;
                        Console.WriteLine(zerostr);
                    }
                    else if (item.Length == 1) {
                        string zero = "00";
                        string zerostr = zero + item;
                        Console.WriteLine(zerostr);
                    }

                    
                }
                else Console.WriteLine(item);


            }
        }

        private static void Exercise4(int[] numbers)
        {
            var s = 0;
            var sortednum = numbers.OrderBy(x => x);
            foreach (var item in sortednum) {
                
                if (s<3)
                {
                    Console.WriteLine(item);
                }

                s++;
            }
        }

        private static void Exercise5(int[] numbers)
        {
            var results = numbers.Distinct();
            var count = results.Count(f => f > 10);
            Console.WriteLine(count);
        }
    }
}
