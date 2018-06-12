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
        public string Index(int numero1, int numero2)
        {
            int somatorio = numero1 + numero2;
            return "ID =" + id + "<br /> Name=" + Request.QueryString["name"].ToString();
        }
    }
}