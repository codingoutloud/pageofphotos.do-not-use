using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PageOfPhotosWebRole.Models;

namespace PageOfPhotosWebRole.Controllers
{
   // TO DO: Page View: Make titlebar more useful than "Index - My ASP.NET MVC Application http://127...." - perhaps "Page Index - www.pageofphotos.com"
   // TODO: Page View: Make legend (or text) say how many pages are available, e.g., "243 Pages Available"
   // TO DO: Page View: Make individual (currently this: <li>@item.Name</li>) to be appropriate link (e.g., "/kevin") using anchor <a> tag
   // TODO: Page View: Create PageDetailModel which shows full details for one page - such as /kevin - create GetFakePageDetailModel to go with it


   public class PageController : Controller
   {
      private PageModel GetFakePageModel()
      {
         var slug1 = new Slug { Name = "kevin" };
         var slug2 = new Slug { Name = "bill" };
         var slug3 = new Slug { Name = "timothy" };
         var slugList = new List<Slug> { slug1, slug2, slug3 };
         var fakePageModel = new PageModel { Slugs = slugList };

         return fakePageModel;
      }

      //
      // GET: /Page/

      public ActionResult Index()
      {
         return View(GetFakePageModel());
      }

    /*  private PageDetailModel GetFakePageDetailModel()
      {
         
      }
      */
      //
      // GET: /Page/Details/5

      public ActionResult Details(int id)
      {
         return View();
      }

      //
      // GET: /Page/Create

      public ActionResult Create()
      {
         return View();
      }

      //
      // POST: /Page/Create

      [HttpPost]
      public ActionResult Create(FormCollection collection)
      {
         try
         {
            // TODO: Add insert logic here

            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }

      //
      // GET: /Page/Edit/5

      public ActionResult Edit(int id)
      {
         return View();
      }

      //
      // POST: /Page/Edit/5

      [HttpPost]
      public ActionResult Edit(int id, FormCollection collection)
      {
         try
         {
            // TODO: Add update logic here

            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }

      //
      // GET: /Page/Delete/5

      public ActionResult Delete(int id)
      {
         return View();
      }

      //
      // POST: /Page/Delete/5

      [HttpPost]
      public ActionResult Delete(int id, FormCollection collection)
      {
         try
         {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }
   }
}
