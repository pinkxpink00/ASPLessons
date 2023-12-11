using System.ComponentModel.DataAnnotations;

namespace ASPLessons.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Не указано имя")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Не указан электронный адрес")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Не указан возраст")]
        [Range(1, 100)]
        public int Age { get; set; }

        public int Password { get; set; }
    }
}
