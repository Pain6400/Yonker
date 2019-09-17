using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YonkerHN.Models.Product
{
    public class ProductListViewModel
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        public string CaregoryName { get; set; }
    }
}