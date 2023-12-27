using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace corsoAsp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
             return Content("sono la index");        
        }

        public IActionResult Detail(string id)
        {
            return Content($"sono Detail, ho ricevuto l'ID{id}"); 
        }
    }
}