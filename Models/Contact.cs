using System.ComponentModel.DataAnnotations;

namespace WebsiteKh.Models
{
    public class Contact
    {
        [Display(Name = "Ваше имя")]
        [Required(ErrorMessage = "Введите ваше имя")]
        public string Name { get; set; }

        [Display(Name = "Ваш возраст")]
        [Required(ErrorMessage = "Введите ваш возраст")]
        public int Age { get; set; }

        [Display(Name = "Ваша почта")]
        [Required(ErrorMessage = "Введите вашу почту")]
        public string Email { get; set; }

        [Display(Name = "Ваше сообщение")]
        [Required(ErrorMessage = "Сообщение не может быть пустым")]
        [StringLength(30, ErrorMessage = "Сообщение слишком длинное!")]
        public string Message { get; set; }

    }
}
