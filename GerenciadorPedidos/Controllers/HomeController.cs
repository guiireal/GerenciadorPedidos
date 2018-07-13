using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GerenciadorPedidos.Filters;
using GerenciadorPedidos.Models;

namespace GerenciadorPedidos.Controllers
{
    [PermissaoAcesso]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.operador = (OPERADOR) TempData["operador"];
            return View();
        }
    }
}