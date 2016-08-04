using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace urlshrtnr.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index(string key)
        //{
        //    ViewData["Key"] = String.Format("Your URL key is {0}", key);

        //    Dictionary<string, string> urls = new Dictionary<string, string>()
        //    {
        //        {"liz", "http://reddit.com"}
        //    };

        //    //301 Redirect to actual URL
        //    return RedirectPermanent(urls[key]);
        //}

        public IActionResult Index()
        {
            ViewData["Key"] = "The other index";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
