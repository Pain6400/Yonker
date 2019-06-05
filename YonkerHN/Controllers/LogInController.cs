using Microsoft.VisualStudio.Services.Licensing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YonkerHN.Models;
using YonkerHN.Models.LogIn;

namespace YonkerHN.Controllers
{
    public class LogInController : Controller
    {
        WorkshopHNContext db = new WorkshopHNContext();

        public ActionResult Index()
        {
            var model = new LogInViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LogInViewModel login)
        {
            foreach (var item in db.UsersHN)
            {
                if (item.UserName == login.UserName && item.Password == login.Password)
                {
                  return RedirectToAction("Index", "Home");
                }
            }

            var nolog = new LogInViewModel
            {
                MessageError = " Usuario o contraseña incorrecto"
            };

            return this.View(nolog);    
        }
    }
}