using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeOne.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeOne.Controllers
{
    public class GreetingsController : Controller
    {
        IGreetable greetable;

        public GreetingsController(IGreetable greetable)
        {
            this.greetable = greetable;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult SubmitForm([FromForm] string name)
        {
            greetable.SetName(name);
            return RedirectToAction("Greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet()
        {
            return View(greetable);
        }
    }
}
