using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var products = new [] { // Anonymous types
        new { Name = "Kayak", Price = 275M },
        new { Name = "LifeJacket", Price = 48.95M },
        new { Name = "Soccer ball", Price = 19.50M },
        new { Name = "Corner flag", Price = 34.95M }
      };

      return View(products.Select(p =>
        $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
    }
  }
}