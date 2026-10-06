using System.ComponentModel.DataAnnotations;

namespace MvcBasicSample.Models
{
    public class Product
    {//商品の情報

        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;


        public int Price { get; set; }
    }
}
