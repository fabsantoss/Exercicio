using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AbstratcController : Controller
    {
        protected  const string  SESSION_CLIENTE_EMAIL = "cliente_email";
        protected  const string  SESSION_CLIENTE_NOME = "nome_cliente";

        protected const string SESSION_CLIENTE_TIPO = "cliente_tipo";


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
            var nomeUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                return nomeUsuario;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuariotipoSession()
        {
            var tipousuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if(!string.IsNullOrEmpty(tipousuario))
            {
                return tipousuario;
            }
            else
            {
                return "";
            }
        }
    }
}