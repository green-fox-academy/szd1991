using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        IRepo repo;

        public TodoController(IRepo repo)
        {
            this.repo = repo;
        }

        [Route("/list")]
        public IActionResult List()
        {
            repo.Create("Buy cloudy apple juice");

            return View(repo.Read());
        }
    }
}
