using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetGenius.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        //Подобие логина которая не работает пока что
        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            if (username == "user" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Неправильное имя пользователя или пароль.";
                return View("Index");
            }
        }
    }
}
