using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraMVC.Controllers
{
    public class DivisaoController : Controller
    {
        // GET: Division
        public int Division(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;

            return resultado;
        }
    }
}