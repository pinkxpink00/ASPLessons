using System.ComponentModel.DataAnnotations;

namespace ASPLessons.Models
{
    public class Person
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
