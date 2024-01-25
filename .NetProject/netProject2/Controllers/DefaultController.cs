using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity; //i add this
using netProject2.Models.Entity;//and this

namespace netProject2.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {
            var result = c.Hotel.ToList();
            return View(result);
        }
    }
}