using FakeCloneOfAFakeReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeCloneOfAFakeReddit.Repositories
{
    public interface IRedditRepository<T>
    {
        List<T> GetAll();
        T GetById(long id);
        void Create(T item);
        void Upvote(long id);
        void Downvote(long id);
        T DeletePost(long id);
        void Modify(long id, T modifiedItem);
    }
}
