using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace corsoAsp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}