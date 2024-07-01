using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    
    public class AccountController : Controller
    {
        private AppDbContext db;

        public AccountController(AppDbContext context)
        {
            db = context;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserLogin = model.Email, UserPassword = model.Password, UserName = model.Name, UserRole = 1 };
                db.Users.Add(user);
                await db.SaveChangesAsync();


                return RedirectToAction("Register");
            }

            return View(model);
        }


        public IActionResult Login()
        {
            return View();
        }
    }
}