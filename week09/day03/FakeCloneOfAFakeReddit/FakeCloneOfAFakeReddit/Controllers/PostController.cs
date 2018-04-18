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
        private IPostRepository postRepo;

        public PostController(IPostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        [HttpGet]
        [Route("/posts")]
        public IActionResult Index()
        {
            return new OkObjectResult(postRepo.GetAllPosts());
        }

        [HttpPost]
        [Route("/posts")]
        public IActionResult Post([FromBody] Post post)
        {
            postRepo.CreatePost(post);
            return new OkObjectResult(post);
        }

        [HttpPut]
        [Route("/posts/{id}/upvote")]
        public IActionResult Upvote([FromRoute] long id)
        {
            postRepo.Upvote(id);
            return new OkObjectResult(postRepo.GetPostById(id));
        }

        [HttpPut]
        [Route("/posts/{id}/downvote")]
        public IActionResult Downvote([FromRoute] long id)
        {
            postRepo.Downvote(id);
            return new OkObjectResult(postRepo.GetPostById(id));
        }
        
        [HttpDelete]
        [Route("/posts/{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            return new OkObjectResult(postRepo.DeletePost(id));
        }
    }
}
