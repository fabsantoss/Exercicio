using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AbstratcController : Controller
    {
        protected  const string  SESSION_CLIENTE_EMAIL = "cliente_email";
        protected  const string  SESSION_CLIENTE_NOME = "nome_cliente";


        protected string ObterUsuarioSession()
        {
            var usuario = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if(!string.IsNullOrEmpty(usuario))
            {
                return usuario;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioNomeSession()
        {
            var nomeusuario = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nomeusuario))
            {
                return nomeusuario;
            }
            else
            {
                return "";
            }
        }
    }
}