using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Person
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{3,8}", ErrorMessage = "Некорректное имя, имя должно состоять от 3 до 8 символов")]
        public string FirstName { get; set; } 
        [Required]
        [RegularExpression(@"[A-Za-z]{3,12}", ErrorMessage = "Некорректное имя, имя должно состоять от 3 до 12 символов")]
        public string SecondName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{4,15}", ErrorMessage = "Некорректное имя, имя должно состоять от 4 до 15 символов")]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        [Remote(action: "CheckEmail", controller: "Home", ErrorMessage = "Email уже используется")]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]{8,15}", ErrorMessage = "Некорректный пароль,пароль должен состоять от 8 до 15 строчных и прописных латинских букв, цифр, спецсимволов.")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
        
    }
}
