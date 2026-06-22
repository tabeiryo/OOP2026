using Section01;
using System.Threading.Channels;

namespace section01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var numbers = new List<int> { 9, 7, 5, 4, 22, 5, 4, 0, 4, 1, 0, 4 };
            var books = Books.GetBooks();
            var priceAvelage = books.Average(x => x.Price);
            var pageSUM = books.Sum(x => x.Pages);
            var maxPrice = books.Max(x => x.Price);
            var booook = books.FindAll(x => x.Price >= 500);
            
            


            Console.WriteLine("平均金額:" + priceAvelage);
            Console.WriteLine("合計ページ:" + pageSUM);
            Console.WriteLine("高価な本:" + maxPrice);
            foreach (var book in booook)
            {
                Console.WriteLine("500円以上の本:" + book.Title);
            }
            Console.WriteLine("250ページ以上の本上位3冊:");
            var results = books.Where(n => n.Pages > 250).Take(3);
            foreach (var item in results)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
