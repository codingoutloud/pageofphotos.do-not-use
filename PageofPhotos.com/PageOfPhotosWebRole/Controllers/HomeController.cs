using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// TODO:mark some account names as secured
// TODO:expand PageOfPhotos description in About page and/or Home page
// TODO:expand book descripton

namespace PageOfPhotosWebRole.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewBag.Message = "Fear the wrath of the photos.";

         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "About this app.";

         return View();
      }

      public ActionResult Book()
      {
         ViewBag.Message = "About the Book.";

         return View();
      }
   }
}
