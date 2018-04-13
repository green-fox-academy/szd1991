using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodosForLife.Models;

namespace TodosForLife.Repositories
{
    public interface ITodoRepository
    {
        void AddNew(Todo todo);
        List<Todo> GetAll();
        Todo GetById(long id);
        void FullUpdate(long id, string newTask, bool isUrgent, bool isDone);
        void Rename(long id, string newTask);
        void SwitchUrgency(long id, bool isUrgent);
        void SwitchCompletion(long id, bool isDone);
        void Remove(long id);
        List<Todo> Search(string query);
    }
}
