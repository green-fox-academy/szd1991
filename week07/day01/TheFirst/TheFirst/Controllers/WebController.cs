using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheFirst.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheFirst.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        // GET: /<controller>/

        [Route("greeting")]
        public IActionResult Greeting(string name = "Lúzer")
        {
            var greeting = new Greeting(name);

            return View(greeting);
        }
    }
}
