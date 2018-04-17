using System;
using FrontEndRest.Models;
using FrontEndRest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndRest.Controllers
{
    public class HomeController : Controller
    {
        private ILogRepository logRepo;

        public HomeController(ILogRepository logRepo)
        {
            this.logRepo = logRepo;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            logRepo.Archive("/", "index.html");

            return File(@"~\index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            logRepo.Archive("/doubling", $"input={input}");

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
            logRepo.Archive("/greeter", $"name={name}&title={title}");

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
            logRepo.Archive("/appenda/{appendable}", $"appendable={appendable}");

            string appendA = appendable + "a";
            return Json(new { appended = appendA });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult AppendA()
        {
            logRepo.Archive("/appenda/", "");

            return NotFound();
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] DoUntilDTO Until)
        {
            logRepo.Archive("/dountil/{what}", $"what={what}, until={Until.Until}");

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
            logRepo.Archive("/arrays", $"what={arrayHandler.What}, array={arrayHandler.NumbersToString()}");

            if (arrayHandler.What == null || arrayHandler.Numbers == null)
            {
                return Json(new { error = "Please provide what to do with the numbers and/or the numbers themselves!" });
            }
            else if (arrayHandler.What == "sum")
            {
                return Json(new { result = arrayHandler.Sum() });
            }
            else if (arrayHandler.What == "multiply")
            {
                return Json(new { result = arrayHandler.Multiply() });
            }
            else if (arrayHandler.What == "double")
            {
                return Json(new { result = arrayHandler.Double() });
            }
            return NotFound();
        }

        [HttpGet]
        [Route("/log")]
        public IActionResult Log()
        {
            return Json(new { entries = logRepo.ReadAll() });
        }
    }
}