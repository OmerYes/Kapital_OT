using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OT.DAL.Entities;
    
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
        public IActionResult Index(User user)
        {
            User model = unit.UserRepo.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (model != null)
            {
                FormsAuthentication
            }
            return

        }
    }
}
