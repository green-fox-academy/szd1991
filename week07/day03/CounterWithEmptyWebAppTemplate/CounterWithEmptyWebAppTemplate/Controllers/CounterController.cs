using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CounterWithEmptyWebAppTemplate.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterWithEmptyWebAppTemplate.Controllers
{
    public class CounterController : Controller
    {
        private ICountable countable;

        public CounterController(ICountable countable)
        {
            this.countable = countable;
        }

        [HttpGet("/")]
        public IActionResult ShowCounter()
        {
            return View(countable.GetNumber());
        }

        [HttpPost("/")]
        public IActionResult Count()
        {
            countable.Count();
            return RedirectToAction("ShowCounter");
        }
    }
}
