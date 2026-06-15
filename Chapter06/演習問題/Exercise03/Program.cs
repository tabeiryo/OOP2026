
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Net.WebSockets;
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            var count=0;
            foreach (var c in text)
            {
                if (c == ' ') { count++; }
            }
            Console.WriteLine(count);
        }

        private static void Exercise2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3(string text) {
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var separator = " ";
            
              var result =String .Join(separator, words);

            result += ".";
            Console.WriteLine(result);
             
        }

        private static void Exercise4(string text) {
            var cnt =0;
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                cnt++;
            }
            Console.WriteLine(cnt);
        }

        private static void Exercise5(string text) {
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
             
            foreach (var word in words) {
                if (word.Length <= 4)
                {
                    Console.Write(word+",");
                }
            }
            Console.WriteLine();
        }

        private static void Exercise6(string text) {
            
        }
    }
}
