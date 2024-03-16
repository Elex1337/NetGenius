using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetGenius.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        //Desing controller
        [HttpGet("design")]
        public IActionResult Design()
        {
            return View();
        }
        //Technology controller
        [HttpGet("technology")]
        public IActionResult Technology()
        {
            return View();
        }
        //Webflow controller
        [HttpGet("webflow")]
        public IActionResult Webflow()
        {
            return View();
        }
    }
}

