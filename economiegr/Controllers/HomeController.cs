using economiegr.BusinessLogic;
using economiegr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace economiegr.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }


    public IActionResult Index(string actname)
    {


      using (greeceprojectdbContext db = new greeceprojectdbContext())
      {
        ViewBag.Activities = db.Activities.ToList();
        ViewBag.Technologies = db.Technologies.ToList();
      }

      QueryAll queryAll = new QueryAll();
      if (!String.IsNullOrEmpty(actname))
      {
        var model = queryAll.GetFeeds(new SqlConnection("Server=DESKTOP-F56NIVV;Database=greeceprojectdb;Trusted_Connection=True;"), actname);
        return View(model);

      }
      return View(new List<ViewModels.SetAllVariables>());
    }


    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


  }
}
