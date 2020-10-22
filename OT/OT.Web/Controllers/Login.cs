using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OT.DAL.Entities;
using OT.Web.Models.VM;

namespace OT.Web.Controllers
{
    public class Login : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserVM user)
        {
            if (LoginUser(user))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email)
                 };

                var UserIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(UserIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");

            }
    
            return View();
        }

        private bool LoginUser(UserVM user)
        {
            User model = unit.UserRepo.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (model!=null)
            {
                return true;
            }
            else
            {
               return false;
            }
                
        }
    }
}
