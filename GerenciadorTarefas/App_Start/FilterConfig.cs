using GerenciadorTarefas.DAL;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GerenciadorTarefas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeUserAttribute());
        }
    }
    
    public class AuthorizeUserAttribute : AuthorizeAttribute
    {

        private GerenciadorTarefasContext db = new GerenciadorTarefasContext();

        // Custom property
        public string Perfil { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool verificaPerfil = false;

            var isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                verificaPerfil = false;
            }
            if (this.Perfil == null)
            {
                verificaPerfil = true;

            } else {
                var perfil = db.Perfil.FirstOrDefault(p => p.Nome == this.Perfil);
                var usuario = db.Usuario.FirstOrDefault(u => u.Nome == httpContext.User.Identity.Name.ToString());
                if (usuario != null && perfil != null)
                {
                    if (usuario.PerfilId == perfil.PerfilId)
                    {
                        verificaPerfil = true;
                    }
                }
            }
            return verificaPerfil;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                            controller = "Home",
                                action = "AcessoNegado"
                            })
                        );
        }
    }
}
