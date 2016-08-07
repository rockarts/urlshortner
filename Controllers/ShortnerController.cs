using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace urlshortner.Controllers
{
    public class ShortnerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string key)
        {
            ViewData["Key"] = String.Format("Your URL key is {0}", key);

            Dictionary<string, string> urls = new Dictionary<string, string>()
            {
                {"liz", "http://reddit.com"}
            };

            //301 Redirect to actual URL
            return RedirectPermanent(urls[key]);
        }

        [HttpPost]
        public IActionResult Shorten(Url url)
        {
            throw new NotImplementedException();

            //return CreatedAtRoute("GetTodo", new { id = item.Key }, item);
        }

    }
}
