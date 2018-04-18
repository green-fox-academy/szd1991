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
        void CreatePost(Post post);
        void Upvote(long id);
        void Downvote(long id);
        Post DeletePost(long id);
    }
}
