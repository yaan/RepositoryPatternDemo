using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryPatternDemo.Repositories;
using RepositoryPatternDemo.ViewModels;

namespace RepositoryPatternDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ProductRepository productRepo = new ProductRepository();
            ProductModel product = productRepo.GetProduct("My Product");

            return View(product);
        }

    }
}
