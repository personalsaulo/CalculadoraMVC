using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraMVC.Controllers
{
    public class SubtracaoController : Controller
    {
        // GET: Subtracao
        public int Subtraction(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;

            return resultado;
        }
    }
}