using System;
using System.ComponentModel;

namespace section01
{
    internal class Program
    {
        public delegate bool Judgement(int value);

        static int Count(int num) {
            var numbers = new int[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var count = 0;

            Judgement judge = ISEEBN;

            var count Count(numbers n => n%2==0);
            Console.WriteLine(count);

            static int Count(int[] numbers.Predicate<int> judge) { 
            var count = 0;
foreach (var n in numbers)
            {
                if (judge(in)==true)
                {
                    count++;
                }
            }
            return count;
        }
            }



            
        static void Main(string[] args)
        {
            int count = 5;
            Console.WriteLine(Count(count));

        }

        static bool ISEEBN(int n) { 
        return (n%2==0);
        }

    }
}
