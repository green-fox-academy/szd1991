using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    [Route("greatest-web-app-ever")]
    public class CounterController : Controller
    {
        private ICountable countable;

        public CounterController(ICountable countable)
        {
            this.countable = countable;
        }

        // GET: /<controller>/
        [Route("counter")]
        public IActionResult Count()
        {
            return View(countable.Count(1));
        }
    }
}
