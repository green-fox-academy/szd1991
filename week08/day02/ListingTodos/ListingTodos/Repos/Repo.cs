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

        public void Create(string title, bool isUrgent)
        {
            context.Add(new Todo
            {   Title = title,
                IsUrgent = isUrgent
            });

            context.SaveChanges();
        }

        public List<Todo> Read()
        {
            return context.Todos.ToList();
        }

        public void FullUpdate(long id, string newTitle, bool isUrgent, bool isDone)
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

        public List<Todo> Search(string query)
        {
            return context.Todos.Where(td => td.Title.Contains(query)).ToList();
        }

        public void UpdateDoneState(long id, bool isDone)
        {
            Todo todo = context.Todos.FirstOrDefault(td => td.Id == id);

            todo.IsDone = todo.IsDone ? false : true;

            context.Update(todo);

            context.SaveChanges();
        }

        public void UpdateUrgentState(long id, bool isUrgent)
        {
            Todo todo = context.Todos.FirstOrDefault(td => td.Id == id);

            todo.IsUrgent = todo.IsUrgent ? false : true;

            context.Update(todo);

            context.SaveChanges();
        }

        public void UpdateTitle(long id, string newTitle)
        {
            Todo todo = context.Todos.FirstOrDefault(td => td.Id == id);

            todo.Title = newTitle;

            context.Update(todo);

            context.SaveChanges();
        }
    }
}
