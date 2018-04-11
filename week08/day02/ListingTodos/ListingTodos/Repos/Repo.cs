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

        public void Create(string title, bool isUrgent, bool isDone)
        {
            context.Add(new Todo
            {   Title = title,
                IsUrgent = isUrgent,
                IsDone = isDone
            });

            context.SaveChanges();
        }

        public List<Todo> Read()
        {
            return context.Todos.ToList<Todo>();
        }

        public void Update(long id, string newTitle, bool isUrgent, bool isDone)
        {
            Todo todo = context.Todos.FirstOrDefault(td => td.Id == id);

            if (newTitle != null)
            {
                todo.Title = newTitle;
            }

            todo.IsUrgent = isUrgent;

            todo.IsDone = isDone;

            context.Update(todo);

            context.SaveChanges();
        }

        public void Delete(long id)
        {
            Todo todo = context.Todos.FirstOrDefault(td => td.Id == id);

            context.Remove(todo);

            context.SaveChanges();
        }
    }
}
