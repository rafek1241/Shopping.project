using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Core.Areas.ShopPage.Controllers
{
    public class IndexController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}