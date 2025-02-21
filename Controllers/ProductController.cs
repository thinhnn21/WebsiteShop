using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMitilShop.Context;
using WebMitilShop.Models;

namespace WebMitilShop.Controllers
{
    public class ProductController : Controller
    {
        Model1 objModel1 = new Model1();
        // GET: Product
        public ActionResult Detail(int Id)
        {
            HomeModel objHomeModel = new HomeModel();
            objHomeModel.ListCategory = objModel1.Categories.ToList();
            objHomeModel.ListProduct = objModel1.Products.ToList();
            objHomeModel.OneProduct = objModel1.Products.Where(n => n.ProductId == Id).FirstOrDefault();
            objHomeModel.OneCategory = objModel1.Categories.Where(n => n.CategoryId == Id).FirstOrDefault();
            return View(objHomeModel);
        }
    }
}