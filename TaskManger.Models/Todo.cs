using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManger.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; } // 0 - New, 1 - InProgress, 2 - Completed
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public DateTime Completed { get; set; }

        public int OwnerId { get; set; } = 1;
    }

    public enum TaskStatus
    {
        New,
        InProgress,
        Completed
    }
}
