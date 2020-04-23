using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Site.Models;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext db;
        public HomeController(LibraryContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
