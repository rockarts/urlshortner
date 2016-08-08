using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace urlshortner.Controllers
{
    public class ShortnerController : Controller
    {
        [FromServices]
        public IRepository urlList { get; set; }

        public IActionResult Index(string key)
        {
            Url url = new Url();
            url.ShortenedURL = key;
            url.LongURL = urlList.Get(url.Decode(key));
            ViewData["Key"] = String.Format("Your URL key is {0}", key);
            //301 Redirect to actual URL
            return RedirectPermanent(url.LongURL);
        }

        [HttpPost]
        public IActionResult Shorten(Url url)
        {
            int key = urlList.Add(url.LongURL.ToString());
            string shortUrl = url.Encode(key);
            ViewData["ShortUrl"] = string.Format("Your Short URL is: http://localhost/{0}",  shortUrl);
            return View("~/Views/Home/Index.cshtml");
            //return CreatedAtRoute("GetTodo", new { id = item.Key }, item);
        }

    }
}
