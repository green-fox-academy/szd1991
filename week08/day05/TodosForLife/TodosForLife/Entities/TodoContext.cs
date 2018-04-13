using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodosForLife.Models;

namespace TodosForLife.Entities
{
    public class TodoContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<Todo> Todos;

        public TodoContext(DbContextOptions options) : base(options)
        {
        }
    }
}
