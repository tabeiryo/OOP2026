using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleCalculder
{
    internal class uriagesyuukei
    {
        private readonly IEnumerable<Sale> _sales;

        public uriagesyuukei(string filePath)
        {
            _sales = ReadSales(string filePath); }
            public IEnumerable<Sale> ReadSales(string filePath)
            {
               public var Sale sales = new List<Sale>();
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] items = line.Split(',');
                    Sale sale = new Sale()
                    {
                        Shopname = items[0],
                        productCategory = items[1],
                        Amount = int.Parse(items[2]),
                    };
                    sales.Add(sale);
                }
                return sales;
            }
        
        public IDictionary<string, int> GetPerStoreSales(){
             var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.Shopname))//店舗名が登録されているか
                    dict[sale.Shopname] += sale.Amount;
                else dict[sale.Shopname] = sale.Amount;
                }
            return dict;
        }
        }
}
