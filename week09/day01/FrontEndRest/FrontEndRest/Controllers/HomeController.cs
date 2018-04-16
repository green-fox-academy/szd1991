using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndRest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontEndRest.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return File(@"~\index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            string appendA = appendable + "a";
            return Json(new { appended = appendA });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult AppendA()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] DoUntilDTO Until)
        {
            if (what == "sum")
            {
                if (Until.Until == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                return Json(new { result = Until.SumUntil() });
            }
            if (what == "factor")
            {
                if (Until.Until == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                return Json(new { result = Until.FactorUntil() });
            }
            return NotFound();
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult Arrays([FromBody] ArrayHandlerTDO arrayHandler)
        {
            if (arrayHandler.What == null)
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
            else if (arrayHandler.What == "sum")
            {
                if (arrayHandler.Numbers == null)
                {
                    return Json(new { error = "Please provide numbers!" });
                }

                return Json(new { result = arrayHandler.Sum() });
            }
            else if (arrayHandler.What == "multiply")
            {
                if (arrayHandler.Numbers == null)
                {
                    return Json(new { error = "Please provide numbers!" });
                }

                return Json(new { result = arrayHandler.Multiply() });
            }
            else if (arrayHandler.What == "double")
            {
                if (arrayHandler.Numbers == null)
                {
                    return Json(new { error = "Please provide numbers!" });
                }

                return Json(new { result = arrayHandler.Double() });
            }
            return NotFound();
        }
    }
}