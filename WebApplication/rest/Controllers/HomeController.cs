using api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api.Services;

namespace rest.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHomeService _homeService;

        public HomeController()
        {
            _homeService = new HomeService();
        }

        public ActionResult Index()
        {
            var model = _homeService.GetIndexData();

            return View("Index", model:model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}