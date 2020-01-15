using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api.Interfaces;
using api.Services;
using model.ViewModels;


namespace rest.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index()
        {
            var somedata = _productService.GetProducts();
            return View("Index",model:somedata);
        }
        public ActionResult ProductUser()
        {
            var somedata = _productService.GetProductUserViewModel();
            return View("ShytanIndex", model: somedata);
        }

        public ActionResult ProductUserPayment()
        {
            var somedata = _productService.GetProductUserPaymentViewModel();
            return View("YakadzunIndex", model: somedata);
        }

        public ActionResult ProductUserPayment2()
        {
            var somedata = _productService.GetProductUserPaymentViewModel2();
            return View("YakaIndex", model: somedata);
        }
        [HttpPost]
        public ActionResult EditPayment(EditViewModel editViewModel)
        {
            _productService.GetEditViewModel(editViewModel );
            return RedirectToAction("ProductUserPayment2");
        }

        [HttpGet]
        public ActionResult EditPayment(int id)
        {
            return View("EditIndex",model : _productService.GetPaymentByAllId(id));
        }
        
    }
}