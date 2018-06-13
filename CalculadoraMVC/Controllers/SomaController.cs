using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraMVC.Controllers
{
    public class SomaController : Controller
    {
        // GET: Soma
        public ActionResult Addition(int numero1, int numero2)
        {
            return View();
        }

        
    }
}