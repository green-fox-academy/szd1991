using FakeCloneOfAFakeReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeCloneOfAFakeReddit.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Post GetPostById(long id);
        void CreatePost(string title, string url);
        void Upvote(long id);
        void Downvote(long id);
        void DeletePost(long id);
    }
}
