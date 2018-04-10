using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class Repo : IRepo
    {
        private TodoContext context;

        public Repo(TodoContext context)
        {
            this.context = context;
        }

        public void Create(string title)
        {
            context.Add(new Todo { Title = title });
            context.SaveChanges();
        }

        public List<Todo> Read()
        {
            return context.Todos.ToList();
        }

        public void Update(Todo todo)
        {
            context.Update(todo);
            context.SaveChanges();
        }

        public void Delete(Todo todo)
        {
            context.Remove(todo);
            context.SaveChanges();
        }
    }
}
