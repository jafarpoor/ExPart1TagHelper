using ExTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExTagHelper.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route("User/Index", Name = "AddUser")]
        [HttpPost]
        public IActionResult Index( User user)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
