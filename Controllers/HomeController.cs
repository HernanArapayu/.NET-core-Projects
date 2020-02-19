using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aplicacion1.Models;

namespace aplicacion1.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

      [BindProperty]
      public Usuario _Usuario {get;set;}


      public IActionResult enviarDatos(){
          return Json(_Usuario);
      }
    }
}
