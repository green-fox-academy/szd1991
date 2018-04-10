﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        [Route("/list")]
        public IActionResult List()
        {
            string message = "This is my first todo...";
            return Content(message);
        }
    }
}
