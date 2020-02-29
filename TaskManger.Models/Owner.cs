using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManger.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public ICollection<Todo> Tasks { get; set; } = new List<Todo>();
    }
}
