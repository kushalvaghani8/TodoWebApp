using System;
using System.ComponentModel.DataAnnotations;

namespace TodoWebApp.Models
{
    public class Todo
    {
        public int ID { get; set; } //making model with id, name, if the to-do is complete or not and date time 
        [Required]
        public string Name { get; set; }
        public Boolean IsDone { get; set; }

        [DataType(DataType.Time)]
        public DateTime? CompletionTime { get; set; }//(its not implemented for time, tho I've included here )

    }
}