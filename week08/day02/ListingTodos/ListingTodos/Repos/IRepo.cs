using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public interface IRepo
    {
        void Create(string title, bool isUrgent, bool isDone);
        List<Todo> Read();
        void Update(long id, string newTitle, bool isUrgent, bool isDone);
        void Delete(long id);
        List<Todo> Search(string keyword);
    }
}
