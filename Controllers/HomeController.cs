using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          List<string> results = new List<string>();

          foreach (var item in Product.GetProducts())
          {
              string name = item?.Name ?? "<No Name>"; // Null Conditional and Null Coalescing
              decimal? price = item?.Price ?? 0;
              string relatedName = item?.Related?.Name ?? "<None>";
              results.Add(string.Format($"Name: {name}, Price: {price}, Related: {relatedName}"));
          }
          return View(results);
        }
    }
}