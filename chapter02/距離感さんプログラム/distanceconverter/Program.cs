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

            
            if (args[0] == "_tom")
            {
                Console.WriteLine("表示範囲1(スタート)を決めてください");
                string? inputnum = Console.ReadLine();

                if (int.TryParse(inputnum, out var x))
                {
                     x = int.Parse(inputnum);

                    Console.WriteLine("表示範囲2(ゴール)を決めてください");
                    string? inputnm = Console.ReadLine();
                    if (int.TryParse(inputnm, out var y))
                    {
                         y = int.Parse(inputnm);

                        printfeetmetalist(x, y);
                        //for (int i = 0; i < 10; i++)
                        //{
                        //  double meto = 0.3048;
                        //Console.WriteLine($"{i}ft={meto:o.oooo}m"}
                    }
                    else Console.WriteLine("引数エラー");
                }
                else Console.WriteLine("引数エラー");
            }
            else if (args[0] == "_tof")
            {
                Console.WriteLine("表示範囲1(スタート)を決めてください");
                string? inptnum = Console.ReadLine();
                if (int.TryParse(inptnum, out var x))
                {
                    x = int.Parse(inptnum);

                    Console.WriteLine("表示範囲2(ゴール)を決めてください");
                    string? inputn = Console.ReadLine();
                    if (int.TryParse(inputn, out var y))
                    {
                        y = int.Parse(inputn);

                        printmetftlist(x, y);
                        //for (int meta = 1; meta <= 10; meta++) {
                        //  double feet = metafeet(meta);
                        //   Console.WriteLine($"{meta}m={feet:o.oooo}ft");
                        //}
                    }
                    else Console.WriteLine("引数エラー");
                }
                else Console.WriteLine("引数エラー");
            }
            else
                Console.WriteLine("引数エラー");
        }
        static void printfeetmetalist(int start, int stop) //ft→m
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meta = FeetConverter.tometer(feet);
                Console.WriteLine($"{feet}ft={meta:0.0000}m");
            }
        }static void printmetftlist(int start, int stop) //m→ft
        {
            for (int met = start; met <= stop; met++)
            {
                double fet = FeetConverter.Frommetar(met);
                Console.WriteLine($"{met}m={fet:0.0000}ft");
            }
        
        }
    }
}
