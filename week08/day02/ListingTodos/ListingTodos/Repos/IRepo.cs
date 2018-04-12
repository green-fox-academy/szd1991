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
        void FullUpdate(long id, string newTitle, bool isUrgent, bool isDone);
        void UpdateDoneState(long id, bool isDone);
        void UpdateUrgentState(long id, bool isUrgent);
        void UpdateTitle(long id, string newTitle);
        void Delete(long id);
        List<Todo> Search(string keyword);
    }
}
