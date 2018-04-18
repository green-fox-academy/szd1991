using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeCloneOfAFakeReddit.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FakeCloneOfAFakeReddit.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository postRepo;

        public PostController(IPostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        [HttpGet]
        [Route("/posts")]
        public IActionResult Index()
        {
            return Json(new { posts = postRepo.GetAllPosts() });
        }

        [HttpPost]
        [Route("/posts")]
        public IActionResult Post([FromBody] string title, [FromBody] string url)
        {
            postRepo.CreatePost(title, url);
            return Ok();
        }
    }
}
