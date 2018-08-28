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
    [Authorize]
    public class HomeController : Controller
    {
        private GerenciadorTarefasContext db = new GerenciadorTarefasContext();

        // GET: /Home/
        [AllowAnonymous]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Tarefas");
        }

        //GET: /TelaLogin/
        [AllowAnonymous]
        public ActionResult TelaLogin()
        {
            return View();
        }

        [AllowAnonymous]
        public JsonResult Login(string nome, string senha)
        {
            try
            {
                Usuario usuario = db.Usuario.FirstOrDefault(u => u.Nome == nome && u.Senha == senha );

                if (usuario != null)
                {
                    var persistCookie = true;
                    var userData = usuario.UsuarioId.ToString();
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                        usuario.Nome,
                        DateTime.Now,
                        DateTime.Now.AddMinutes(10),
                        persistCookie,
                        userData,
                        FormsAuthentication.FormsCookiePath);
                    string encryptTicket = FormsAuthentication.Encrypt(ticket);
                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket));
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

        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View("TelaLogin");
        }

        //GET: /AcessoNegado/
        [AllowAnonymous]
        public ActionResult AcessoNegado()
        {
            return View();
        }
    }

}