using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeCloneOfAFakeReddit.Entities;
using FakeCloneOfAFakeReddit.Models;

namespace FakeCloneOfAFakeReddit.Repositories
{
    public class PostRepository : IRedditRepository<Post>
    {
        private PostContext context;

        public PostRepository(PostContext context)
        {
            this.context = context;
        }

        public void Create(Post post)
        {
            context.Add(post);
            context.SaveChanges();
        }

        public Post DeletePost(long id)
        {
            Post mimic = GetById(id);
            context.Remove(GetById(id));
            context.SaveChanges();
            return mimic;
        }

        public void Downvote(long id)
        {
            Post post = GetById(id);
            post.Score--;
            context.Update(post);
            context.SaveChanges();
        }

        public List<Post> GetAll()
        {
            return context.Posts.ToList();
        }

        public Post GetById(long id)
        {
            return context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Modify(long id, Post modifiedPost)
        {
            Post post = GetById(id);
            
            if (modifiedPost.Title != null)
            {
                post.Title = modifiedPost.Title;
            }
            if (modifiedPost.Url != null)
            {
                post.Url = modifiedPost.Url;
            }

            context.Update(post);
            context.SaveChanges();
        }

        public void Upvote(long id)
        {
            Post post = GetById(id);
            post.Score++;
            context.Update(post);
            context.SaveChanges();
        }
    }
}
