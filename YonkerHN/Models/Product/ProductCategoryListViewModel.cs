using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YonkerHN.Models.Product
{
    public class ProductCategoryListViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Categorua")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}