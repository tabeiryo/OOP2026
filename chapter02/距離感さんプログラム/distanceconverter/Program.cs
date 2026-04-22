using System.ComponentModel.Design;

namespace distanceconverter
{
    internal class Program
    {
        static double feetmeta(int ft)
        {
            return ft * 0.3048;
        }
        static double metafeet(int meta)
        {
            return meta / 0.3048;
        }
static void Main(string[] args)
        {
            Console.WriteLine("_tomか_tofを入力");
            string? arg = Console.ReadLine();
            args[0] = arg;

            Console.WriteLine("表示範囲1を決めてください");
            string? inputnum = Console.ReadLine();
            int x = int.Parse(inputnum);

            Console.WriteLine("表示範囲2を決めてください");
            string? inputnm = Console.ReadLine();
            int y = int.Parse(inputnm);

            if (args[0] == "_tom")
            {
                printfeetmetalist(x, y);
                //for (int i = 0; i < 10; i++)
                //{
                //  double meto = 0.3048;
                //Console.WriteLine($"{i}ft={meto:o.oooo}m"}
             }
            else if (args[0] == "_tof")
            {
                printmetftlist(x, y);
                //for (int meta = 1; meta <= 10; meta++) {
                //  double feet = metafeet(meta);
                //   Console.WriteLine($"{meta}m={feet:o.oooo}ft");
                //}
            }
            else
                Console.WriteLine("引数エラー");
        }
        static void printfeetmetalist(int start, int stop) //ft→m
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meta = feetmeta(feet);
                Console.WriteLine($"{feet}ft={meta:0.0000}m");
            }
        }
        static void printmetftlist(int start, int stop) //m→ft
        {
            for (int met = start; met <= stop; met++)
            {
                double fet = feetmeta(met);
                Console.WriteLine($"{met}m={fet:0.0000}ft");
            }
        }
    }
}
