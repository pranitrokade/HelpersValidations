using HelpersValidations.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersValidations.Controllers
{
    public class AccountController : Controller
    {
      
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel loginModel)
        {
            if (ModelState.IsValid)
            {
               return RedirectToAction("Message");
            }
            else
            {
                return View(loginModel);
            }            
        }

        public string Message()
        {
            return "";
        }

    }
}
