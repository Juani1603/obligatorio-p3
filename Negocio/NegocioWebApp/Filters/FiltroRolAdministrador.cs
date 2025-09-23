using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NegocioWebApp.Filters
{
    public class FiltroRolAdministrador : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? idLogueado = context.HttpContext.Session.GetInt32("usuarioId");

            if (idLogueado == null)
            {
                context.Result = new RedirectToActionResult("Index", "Home", new { mensaje = "No tiene permisos de rol para esta acción." });
            }
            base.OnActionExecuting(context);
        }
    }
}
