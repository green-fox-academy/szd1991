using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodosForLife.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();
    }
}