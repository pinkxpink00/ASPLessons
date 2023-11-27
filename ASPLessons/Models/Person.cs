using System.ComponentModel.DataAnnotations;

namespace ASPLessons.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name must required")]
        public string? Name { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Email must required")]
        public string? Email {  get; set; }
        [Required]
        public string? Password { get; set; }


    }
}
