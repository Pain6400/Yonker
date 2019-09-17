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
        YonkersContext db = new YonkersContext();

        public ActionResult Index()
        {
            var model = new LogInViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LogInViewModel login)
        {
            foreach (var item in db.Usuario)
            {
                if (item.Empleado.Any())
                {
                    foreach (var item2 in item.Empleado)
                    {
                        if (item2.nombreemp == login.UserName && item2.contraseña == login.Password)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                {
                    foreach (var item2 in item.Cliente)
                    {
                        if (item2.nombrecli == login.UserName && item2.contraseña == login.Password)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
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