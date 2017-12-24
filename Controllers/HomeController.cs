using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      Dictionary<string, Product> products = new Dictionary<string, Product>
      {
        ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        ["LifeJacket"] = new Product { Name = "LifeJacket", Price = 48.95M }
      };

      return View(products.Keys);
    }
  }
}