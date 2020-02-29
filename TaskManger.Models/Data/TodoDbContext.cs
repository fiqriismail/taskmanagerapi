using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManger.Models.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public TodoDbContext(DbContextOptions options) : base(options)
        {}
    }
}
