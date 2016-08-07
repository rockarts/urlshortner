using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace urlshrtnr.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Key"] = "Get";
            return View();
        }

        [HttpPost]
        public IActionResult Shorten(Url url)
        {
            url.ShortenedURL = "http://test.com";
            ViewData["Key"] = "The other index";
            return View("Index", url);
        }

    }
}
