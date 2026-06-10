using System.Globalization;

namespace section01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str1 = "カスてら";
            var str2 = "かすてら";

            var cultureInfo = new CultureInfo("ja-JP");

                if (String.Compare(str1,str2,cultureInfo,CompareOptions.IgnoreKanaType)==0)
            {
                Console.WriteLine("等しい");
            }else Console.WriteLine("等しくない");
        }
    }
}
