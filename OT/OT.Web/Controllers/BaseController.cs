using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OT.Business.Manager.Repository;

namespace OT.Web.Controllers
{
    public class BaseController : Controller
    {
        public UnitOfWork unit;
        public BaseController()
        {
            unit = new UnitOfWork();
        }
        protected override void Dispose(bool disposing)
        {
            unit.Dispose();
            base.Dispose(disposing);
        }
    }
}