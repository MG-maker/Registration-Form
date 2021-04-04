using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person person)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Create");
            else
                return View(person);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            return Content($"{person.FirstName} - {person.SecondName} - {person.UserName} - {person.Gender} - {person.Password}");
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckEmail(string email)
        {
            if (email == "admin@mail.ru" || email == "admin@gmail.com" || email == "admin@yandex.ru")
                return Json(false);
            return Json(true);
        }
    }
}
