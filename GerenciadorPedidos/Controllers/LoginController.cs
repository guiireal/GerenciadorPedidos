using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GerenciadorPedidos.Models;
using GerenciadorPedidos.DAO;

namespace GerenciadorPedidos.Controllers
{
    public class LoginController : Controller
    {
        [Route("login")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Autentica(string identificacao, string senha)
        {
            OPERADOR operador = LoginDAO.GetUsuario(identificacao, senha);
            if (operador != null)
            {
                Session["operador"] = operador;
                TempData["operador"] = (OPERADOR) Session["operador"];
                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("Index");
        }
    }
}