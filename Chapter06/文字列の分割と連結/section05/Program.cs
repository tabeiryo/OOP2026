using System.ComponentModel.DataAnnotations;
using System.Text;

namespace section05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ff = GetWords();
            var separator = ",";
            var sb = new StringBuilder();
            //foreach (var word in GetWords())
            //{
                //if (word == "Strawberry")
                //{
                //   sb.Append(word);
                //}else sb.Append(word+",");
            //}

            var result = String.Join(separator, ff);

            Console.WriteLine(sb);

            //var text = sb.ToString;
        }
        private static IEnumerable<string> GetWords()
        {
            return ["Orange", "Lemonn", "Strawberry"];
        }
    }
}
