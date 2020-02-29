using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Services.Interfaces;
using TaskManger.Models;

namespace TaskManager.Services
{
    public class TodoService : ITodoService
    {
        public List<Todo> GetTodos() 
        {
            var todoList = new List<Todo>();
            for (int i=1; i<10; i++)
            {
                todoList.Add(new Todo() {
                    Id = i,
                    Title = $"Todo - {i}",
                    Description = "This is a temporory todo",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = i % 3 == 0 ? TaskStatus.New : TaskStatus.InProgress
                });
            }
            return todoList;
        }
    }
}
