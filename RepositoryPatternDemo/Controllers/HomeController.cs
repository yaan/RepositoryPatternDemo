using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryPatternDemo.Interfaces;
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
            // instantiate the repository interface, not the concrete class.
            // this enables you to add things like dependency injection easily
            ProductRepository productRepo = new IProductRepository();
            ProductModel product = productRepo.GetProduct("My Product");

            return View(product);
        }

    }
}
