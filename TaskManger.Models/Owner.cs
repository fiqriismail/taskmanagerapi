using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TaskManger.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [StringLength(120)]
        public string FirsName { get; set; }
        [StringLength(120)]
        public string LastName { get; set; }

        public ICollection<Todo> Tasks { get; set; } = new List<Todo>();
    }
}
