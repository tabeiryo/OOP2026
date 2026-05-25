

namespace secsion04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = null;
            if (name is null)
                Console.WriteLine("nameはNULL");
            string oode = "12345";



            var messege = GetMessege(oode) ??  DefaultMessage();
            Console.WriteLine(messege);



            messege = null;
            messege ??= DefaultMessage();



            Sale sale = new Sale() {
                Shopname = "aaa",
            productCategory = "bbb",
            Amount = 100
            };

            int? amount = sale ? Amount;
            Console.WriteLine("売上高:" +amount);


        }

        private static string? DefaultMessage()
        {
            return "DefaultMessage" ;
        }

        private static string? GetMessege(string oode)
        {
            return null ;
        }
        public class Sale
        {
            public string Shopname { get; set; } = string.Empty;

            public string productCategory { get; set; } = string.Empty;

            public int Amount { get; set; }


        }
    }
}
