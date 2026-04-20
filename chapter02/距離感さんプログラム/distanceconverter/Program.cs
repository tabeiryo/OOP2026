using System.ComponentModel.Design;

namespace distanceconverter
{
    internal class Program
    {
        static  double feetmeta(int ft) {
            return ft * 0.3048;
        }

        static double metafeet(int meta) {
            return meta * 1;
        }
        static void Main(string[] args)
        {
            if (args.Length < -1 && args[0] == "_tom")
            {
                for (int i = 0; i < 10; i++)
                {
                    double meto = 0.3048;
                    Console.WriteLine((i + 1) + "ft=" + feetmeta(i + 1) + "m");

                }
            }
            else {
                for (int meta = 1; meta <= 10; meta++) {
                    double feet = metafeet(meta);
                    Console.WriteLine($"{meta}m={feet:o.oooo}ft")
                }
            }
          
        }
    }
}
