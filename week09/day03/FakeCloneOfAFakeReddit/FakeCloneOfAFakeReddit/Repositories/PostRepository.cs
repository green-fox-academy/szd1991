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

        public void CreatePost(Post post)
        {
            context.Add(post);
            context.SaveChanges();
        }

        public Post DeletePost(long id)
        {
            Post mimic = GetPostById(id);
            context.Remove(GetPostById(id));
            context.SaveChanges();
            return mimic;
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

        public void Modify(long id, Post modifiedPost)
        {
            Post post = GetPostById(id);
            
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
            Post post = GetPostById(id);
            post.Score++;
            context.Update(post);
            context.SaveChanges();
        }
    }
}
