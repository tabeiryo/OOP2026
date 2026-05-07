namespace SaleCalculder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter( SalesCounter.ReadSales(@"data\sales.csv"));
            SortedDictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
            foreach (var obj in amountsPerStore)
            {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }
        }
        
        
    }
}
