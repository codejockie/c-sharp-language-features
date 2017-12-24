using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
  public class HomeController : Controller
  {
    public async Task<IActionResult> Index()
    {
      long? length = await MyAsyncMethods.GetPageLength();

      return View(new string[] { $"Length: {length}" });
    }
  }
}