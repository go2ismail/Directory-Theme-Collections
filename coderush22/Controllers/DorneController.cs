using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush22.Controllers
{
    public class DorneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Explore()
        {
            return View();
        }

        public IActionResult Listing()
        {
            return View();
        }

        public IActionResult ListingSingle()
        {
            return View();
        }
    }
}