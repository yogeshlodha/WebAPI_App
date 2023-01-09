using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_App.Interface;

namespace WebMVC_App.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository repository;

        //inject dependency
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll();
            return View(data);
        }
    }
}