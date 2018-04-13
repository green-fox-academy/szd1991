using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodosForLife.Models
{
    public class Todo
    {
        public long Id { get; set; }
        public string Task { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public User User { get; set; }
    }
}
