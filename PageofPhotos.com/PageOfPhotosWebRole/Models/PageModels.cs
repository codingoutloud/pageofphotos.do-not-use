using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageOfPhotosWebRole.Models
{
   public class PageModel
   {
      public List<Slug> Slugs { get; set; }
   }

   public class Slug
   {
      public string Name { get; set; }
   }

   public class PageDetailModel
   {
      
   }
}