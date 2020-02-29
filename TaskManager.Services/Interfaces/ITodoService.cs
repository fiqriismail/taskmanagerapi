using System;
using System.Collections.Generic;
using System.Text;
using TaskManger.Models;

namespace TaskManager.Services.Interfaces
{
    public interface ITodoService
    {
        List<Todo> GetTodos();
    }
}
