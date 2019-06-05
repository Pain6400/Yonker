using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YonkerHN.Models.LogIn
{
    public class LogInViewModel
    {
        [Display(Name = "Usuario o correo")]
        public string UserName { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        public string MessageError { get; set; }
    }
}