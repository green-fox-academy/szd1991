using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheFirst.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheFirst.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greet = new Greeting($"Hali, {name}!");

            return new JsonResult(greet);

        }
    }
}
