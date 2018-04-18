using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeCloneOfAFakeReddit.Entities;
using FakeCloneOfAFakeReddit.Models;

namespace FakeCloneOfAFakeReddit.Repositories
{
    public class PostRepository : IPostRepository
    {
        private PostContext context;

        public PostRepository(PostContext context)
        {
            this.context = context;
        }

        public void CreatePost(string title, string url)
        {
            context.Add(new Post { Title = title, Url = url });
            context.SaveChanges();
        }

        public void DeletePost(long id)
        {
            context.Remove(GetPostById(id));
            context.SaveChanges();
        }

        public void Downvote(long id)
        {
            Post post = GetPostById(id);
            post.Score--;
            context.Update(post);
            context.SaveChanges();
        }

        public List<Post> GetAllPosts()
        {
            return context.Posts.ToList();
        }

        public Post GetPostById(long id)
        {
            return context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Upvote(long id)
        {
            Post post = GetPostById(id);
            post.Score++;
            context.Update(post);
            context.SaveChanges();
        }
    }
}
