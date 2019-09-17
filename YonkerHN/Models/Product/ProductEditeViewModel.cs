
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YonkerHN.Models.Product
{
    public class ProductEditeViewModel
    {
        public string Name { get; set; }

        public SelectList CategoryList { get; set; }
    }
}