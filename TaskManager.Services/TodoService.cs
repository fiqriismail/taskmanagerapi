using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TaskManager.Services.Interfaces;
using TaskManger.Models;
using TaskManger.Models.Data;
using TaskManger.ModelMappers;

namespace TaskManager.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoDbContext _context;

        public TodoService(TodoDbContext context)
        {
            _context = context;
        }

        public Todo GetTodo(int id)
        {
            var todo = _context.Todos.Find(id);
            return todo;
        }

        public List<Todo> GetTodos() 
        {
            var todoList = _context.Todos.ToList();
            return todoList;
        }

        //public List<Todo> GetTodos(string filter)
        //{
        //    var filterOn = filter.Split(',');
        //    var todoList = _context.Todos.Select(s => new { s.Id, s.Title }).ToList();
        //    return todoList;
        //}

        public int StoreTodo(TodoMapper mapper)
        {
            var newTodo = new Todo();

            if (mapper.Id > 0)
            {
                newTodo = _context.Todos.Find(mapper.Id);
            }
            
            newTodo.Title = mapper.Title;
            newTodo.Description = mapper.Description;
            newTodo.Status = (TaskStatus)mapper.Status;
            newTodo.Created = mapper.Created;
            newTodo.Due = mapper.Due;
            newTodo.Completed = mapper.Completed;
            newTodo.OwnerId = 1;

            if (mapper.Id == 0)
            {
                _context.Entry(newTodo).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            } else
            {
                _context.Entry(newTodo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            return _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                _context.Remove(todo);
                _context.SaveChanges();
            }
        }
    }
}
