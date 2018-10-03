using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreMVCWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int ID=1)
        {
            //return HtmlEncoder.Default.Encode($"Hello{name}, ID is:{ID}");
            ViewData["Message"] = "Hello" + name;
            ViewData["ID"] = ID;
            return View();
        }
    }
}
