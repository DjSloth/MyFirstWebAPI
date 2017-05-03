using System.ComponentModel.DataAnnotations;

namespace MyFirstWebAPI.Models
{
    public class Todo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Caption { get; set; }
        public string Note { get; set; }
        public bool IsCompleted { get; set; }
    }
}