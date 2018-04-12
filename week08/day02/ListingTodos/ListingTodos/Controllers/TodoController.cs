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

        [HttpGet]
        [Route("/")]
        public IActionResult List()
        {
            return View(repo.Read());
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult Add([FromForm] string title, [FromForm] bool isUrgent, [FromForm] bool isDone)
        {
            repo.Create(title, isUrgent, isDone);

            return RedirectToAction("list");
        }

        [HttpPost]
        [Route("/update/{id}")]
        public IActionResult FullUpdate([FromRoute] long id, [FromForm] string newTitle, [FromForm] bool isUrgent, [FromForm] bool isDone)
        {
            repo.FullUpdate(id, newTitle, isUrgent, isDone);

            return RedirectToAction("list");
        }

        [HttpPost]
        [Route("/update/{id}-done")]
        public IActionResult UpdateDoneState([FromRoute] long id, [FromForm] bool isDone)
        {
            repo.UpdateDoneState(id, isDone);

            return RedirectToAction("list");
        }

        [HttpPost]
        [Route("/update/{id}-urgency")]
        public IActionResult UpdateUrgentState([FromRoute] long id, [FromForm] bool isUrgent)
        {
            repo.UpdateUrgentState(id, isUrgent);

            return RedirectToAction("list");
        }

        [HttpPost]
        [Route("/update/{id}-rename")]
        public IActionResult UpdateTitle([FromRoute] long id, [FromForm] string newTitle)
        {
            repo.UpdateTitle(id, newTitle);

            return RedirectToAction("list");
        }

        [HttpPost]
        [Route("/remove/{id}")]
        public IActionResult Remove([FromRoute] long id)
        {
            repo.Delete(id);

            return RedirectToAction("list");
        }

        [HttpGet]
        [Route("/search")]
        public IActionResult Search([FromQuery] string query)
        {
            return View(repo.Search(query));
        }
    }
}
