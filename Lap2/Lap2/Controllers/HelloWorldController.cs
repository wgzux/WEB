using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Lap2.Controllers
{
    public class HelloWorldController : Controller
    {

        //public string Index()
        //{
        //    return "THS IS MY DEFAULT ACTION";
        //}

        public IActionResult Index()
        {
            return View();
        }

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

