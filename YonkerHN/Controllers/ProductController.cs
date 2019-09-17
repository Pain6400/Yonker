using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YonkerHN.Models;
using YonkerHN.Models.Product;

namespace YonkerHN.Controllers
{
    public class ProductController : Controller
    {

        YonkersContext db = new YonkersContext();
        public ActionResult Index()
        {
            var model = db.Producto.ToList().Select(s => new ProductListViewModel
            {
                Id = s.productoID,
                Name = s.nombrepro,
                CaregoryName = s.Categoria.nombreca
            });

            return this.View(model);
        }

        public ActionResult Create()
        {
            ProductCreateViewModel p = new ProductCreateViewModel();

            using (YonkersContext db = new YonkersContext())
            {
                p.CategoryList = db.Categoria.ToList<Categoria>();
            }
            return this.View(p);
        }

        [HttpPost]
        public ActionResult Create(ProductCreateViewModel createViewModel)
        {
            if (createViewModel == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (this.ModelState.IsValid)
            {
                using (var db = new YonkersContext())
                {
                    Producto pro = new Producto
                    {
                        categoriaID = createViewModel.CategoryId,
                        yonkerID = 1,
                        nombrepro = createViewModel.Name,
                        precio = createViewModel.Precio,
                    };
                    db.Producto.Add(pro);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return this.View(createViewModel);
        }

        public ActionResult Edit()
        {
            var model = new ProductEditeViewModel
            {
            };

            return this.View(model);
        }
    }
}