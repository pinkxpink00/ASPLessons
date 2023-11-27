using System.ComponentModel.DataAnnotations;

namespace ASPLessons.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name must required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string? Name { get; set; }
        [Range(1, 110, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string? PasswordConfirm { get; set; }


    }
}
