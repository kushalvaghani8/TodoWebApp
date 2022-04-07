using System;
using System.ComponentModel.DataAnnotations;

namespace TodoWebApp.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Boolean Completed { get; set; }

        [DataType(DataType.Time)]
        public DateTime CompletionTime { get; set; }
        

    }
}