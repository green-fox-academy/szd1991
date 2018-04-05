using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    public class CounterController : Controller
    {
        private ICountable countable;

        public CounterController(ICountable countable)
        {
            this.countable = countable;
        }

        [HttpGet]
        [Route("")]
        public IActionResult ShowCount()
        {
            return View(countable.getNumber());
        }

        [HttpPost]
        [Route("Count")]
        public IActionResult Count()
        {
            countable.Count();
            return RedirectToAction("ShowCount");
        }
    }
}
