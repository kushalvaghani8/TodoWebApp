using System;
using System.ComponentModel.DataAnnotations;

namespace TodoWebApp.Models
{
    public class Todo
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public Boolean IsDone { get; set; }

        [DataType(DataType.Time)]
        public DateTime? CompletionTime { get; set; }
        
    }
}