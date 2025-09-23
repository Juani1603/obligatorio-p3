using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NegocioWebApp.Filters
{
    public class FiltroAutenticado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string logueado = context.HttpContext.Session.GetString("usuario");

            if (string.IsNullOrWhiteSpace(logueado))
            {
                context.Result = new RedirectToActionResult("Login", "Home", new { mensaje = "Inicie sesión para continuar" });
            }
            base.OnActionExecuting(context);
        }
    }
}
