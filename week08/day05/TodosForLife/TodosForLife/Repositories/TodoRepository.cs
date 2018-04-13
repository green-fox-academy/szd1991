using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodosForLife.Entities;
using TodosForLife.Models;

namespace TodosForLife.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private TodoContext context;

        public TodoRepository(TodoContext context)
        {
            this.context = context;
        }

        public void AddNew(Todo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }

        public void FullUpdate(long id, string newTask, bool isUrgent, bool isDone)
        {
            Todo todo = GetById(id);

            if (newTask != null)
            {
                todo.Task = newTask;
            }

            todo.IsUrgent = isUrgent;

            todo.IsDone = isDone;

            context.Update(todo);

            context.SaveChanges();
        }

        public List<Todo> GetAll()
        {
            return context.Todos.ToList();
        }

        public List<Todo> GetAllByUserId(long id)
        {
            return context.Users.FirstOrDefault(u => u.Id == id).Todos;
        }

        public Todo GetById(long id)
        {
            return context.Todos.FirstOrDefault(td => td.Id == id);
        }

        public void Remove(long id)
        {
            context.Todos.Remove(GetById(id));

            context.SaveChanges();
        }

        public void Rename(long id, string newTask)
        {
            Todo todo = GetById(id);

            todo.Task = newTask;

            context.Update(todo);

            context.SaveChanges();
        }

        public List<Todo> Search(string query)
        {
            return context.Todos.Where(td => td.Task.Contains(query)).ToList();
        }

        public void SwitchCompletion(long id, bool isDone)
        {
            Todo todo = GetById(id);

            todo.IsDone = todo.IsDone ? false : true;

            context.Update(todo);

            context.SaveChanges();
        }

        public void SwitchUrgency(long id, bool isUrgent)
        {
            Todo todo = GetById(id);

            todo.IsUrgent = todo.IsUrgent ? false : true;

            context.Update(todo);

            context.SaveChanges();
        }
    }
}
