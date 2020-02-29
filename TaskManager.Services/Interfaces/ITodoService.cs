using System;
using System.Collections.Generic;
using System.Text;
using TaskManger.ModelMappers;
using TaskManger.Models;

namespace TaskManager.Services.Interfaces
{
    public interface ITodoService
    {
        List<Todo> GetTodos();
        List<Todo> GetTodos(string filter);
        Todo GetTodo(int id);
        int StoreTodo(TodoMapper mapper);
        void Remove(int id);
    }
}
