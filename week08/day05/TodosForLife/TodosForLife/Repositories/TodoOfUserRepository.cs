using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodosForLife.Entities;
using TodosForLife.Models;

namespace TodosForLife.Repositories
{
    public class TodoOfUserRepository : ITodoRepository
    {
        private TodoContext context;

        public TodoOfUserRepository(TodoContext context)
        {
            this.context = context;
        }

        public void AddNew(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void FullUpdate(long id, string newTask, bool isUrgent, bool isDone)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Todo GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void Rename(long id, string newTask)
        {
            throw new NotImplementedException();
        }

        public List<Todo> Search(string query)
        {
            throw new NotImplementedException();
        }

        public void SwitchCompletion(long id, bool isDone)
        {
            throw new NotImplementedException();
        }

        public void SwitchUrgency(long id, bool isUrgent)
        {
            throw new NotImplementedException();
        }
    }
}
