using System.Globalization;

namespace exersise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#1
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            var cultureInfo = new CultureInfo("ja-JP");

            if (String.Compare(str1, str2, cultureInfo, CompareOptions.IgnoreKanaType) == 0)
            {
                Console.WriteLine("等しい");
            }
            else Console.WriteLine("等しくない");


        }
    }
}
