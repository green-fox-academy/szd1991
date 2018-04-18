using FakeCloneOfAFakeReddit.Entities;
using FakeCloneOfAFakeReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeCloneOfAFakeReddit.Repositories
{
    public class UserRepository : IRedditRepository<User>
    {
        private PostContext context;

        public UserRepository(PostContext context)
        {
            this.context = context;
        }

        public void Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User Delete(long id)
        {
            User mimic = GetById(id);
            context.Users.Remove(GetById(id));
            context.SaveChanges();
            return mimic;
        }

        public void Downvote(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(long id)
        {
            return context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Modify(long id, User modifiedUser)
        {
            User user = GetById(id);

            if (modifiedUser.Name != null)
            {
                user.Name = modifiedUser.Name;
            }

            context.Users.Update(user);

            context.SaveChanges();
        }

        public void Upvote(long id)
        {
            throw new NotImplementedException();
        }
    }
}
