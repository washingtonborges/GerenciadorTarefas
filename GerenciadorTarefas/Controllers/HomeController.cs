using GerenciadorTarefas.DAL;
using GerenciadorTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GerenciadorTarefas.Controllers
{
    public class HomeController : Controller
    {
        private GerenciadorTarefasContext db = new GerenciadorTarefasContext();
  
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Login(string nome, string senha)
        {
            try
            {
                var consulta = db.Usuario.Where(u => u.Nome == nome && u.Senha == senha );

                if (consulta.Any())
                {
                    var persistCookie = true;
                    FormsAuthentication.SetAuthCookie(nome, persistCookie);
                }
                else
                {
                    throw new Exception("Usuário ou senha inválido(s)");
                }
            }
            catch (Exception e)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
    }
}