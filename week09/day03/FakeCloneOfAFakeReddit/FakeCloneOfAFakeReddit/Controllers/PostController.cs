using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeCloneOfAFakeReddit.Models;
using FakeCloneOfAFakeReddit.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FakeCloneOfAFakeReddit.Controllers
{
    public class PostController : Controller
    {
        private IRedditRepository<Post> postRepo;

        public PostController(IRedditRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }

        [HttpGet]
        [Route("/posts")]
        public IActionResult Index()
        {
            return new OkObjectResult(postRepo.GetAll());
        }

        [HttpPost]
        [Route("/posts")]
        public IActionResult Post([FromBody] Post post)
        {
            postRepo.Create(post);
            return new OkObjectResult(post);
        }

        [HttpPut]
        [Route("/posts/{id}/upvote")]
        public IActionResult Upvote([FromRoute] long id)
        {
            postRepo.Upvote(id);
            return new OkObjectResult(postRepo.GetById(id));
        }

        [HttpPut]
        [Route("/posts/{id}/downvote")]
        public IActionResult Downvote([FromRoute] long id)
        {
            postRepo.Downvote(id);
            return new OkObjectResult(postRepo.GetById(id));
        }
        
        [HttpDelete]
        [Route("/posts/{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            return new OkObjectResult(postRepo.Delete(id));
        }

        [HttpPut]
        [Route("/posts/{id}")]
        public IActionResult Modify([FromRoute] long id, [FromBody] Post modifiedPost)
        {
            postRepo.Modify(id, modifiedPost);
            return new OkObjectResult(postRepo.GetById(id));
        }
    }
}
