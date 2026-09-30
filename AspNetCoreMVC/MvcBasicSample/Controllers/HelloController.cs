using Microsoft.AspNetCore.Mvc;
using MvcBasicSample.Models;

namespace MvcBasicSample.Controllers
{
    //URLのHelloに対応
    public class HelloController : Controller
    {
        public IActionResult Index() {

            var products = new List<Product>{ 
            
             new Product {
                Name = "ハンバーガー",
                Price = 500
            },
            new Product
            {
                Name = "紅茶",
                Price = 450
            }
            };

            //商品のオブジェクト
            return View(products);
        }
    }
}
