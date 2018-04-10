using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public interface IRepo
    {
        void Create(string title);
        List<Todo> Read();
        void Update(Todo todo);
        void Delete(Todo todo);
    }
}
