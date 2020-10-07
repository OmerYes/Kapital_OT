using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    
    }
}
