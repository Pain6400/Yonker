using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YonkerHN.Models.Product
{
    public class ProductCreateViewModel
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        public string Codigo { get; set; }

        public int Precio { get; set; }

        public int CategoryId { get; set; }

        public List<Categoria> CategoryList { get; set; }
    }
}