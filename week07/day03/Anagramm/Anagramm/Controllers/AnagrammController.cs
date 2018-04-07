using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Anagramm.Controllers
{
    public class AnagrammController : Controller
    {
        [HttpGet("/")]
        public IActionResult Input()
        {
            return View();
        }

        [HttpPost("/analyze")]
        public IActionResult Analyze(string firstWord, string secondWord)
        {

        }

        [HttpGet("/result")]
        public IActionResult Result()
        {

        }
    }
}
