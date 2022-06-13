
using EnAutos_backend.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnAutos_backend.Controllers
{
    public class HomeController : Controller
    {
        private ApDbContext _context { get; }
        public HomeController(ApDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
       
    }
}
