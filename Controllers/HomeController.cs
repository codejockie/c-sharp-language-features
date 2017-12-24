using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      ShoppingCart cart = new ShoppingCart {
          Products = Product.GetProducts()
      };

      Product[] productArray = {
          new Product { Name = "Kayak", Price = 275M },
          new Product { Name = "LifeJacket", Price = 48.95M },
          new Product { Name = "Soccer ball", Price = 19.50M },
          new Product { Name = "Corner flag", Price = 34.95M }
      };
      decimal cartTotal = cart.TotalPrices();
      decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

      return View(new string[] {
          $"Cart Total: {cartTotal:C2}",
          $"Array Total: {arrayTotal:C2}" });
    }
  }
}