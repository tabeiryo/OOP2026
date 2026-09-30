using Microsoft.AspNetCore.Mvc;

namespace MvcBasicSample.Controllers
{
    //URLのHelloに対応
    public class HelloController : Controller
    {
        public IActionResult Index() { 
            //return Content("はじめてのASP.NET Core");
            return View();
        }
    }
}
