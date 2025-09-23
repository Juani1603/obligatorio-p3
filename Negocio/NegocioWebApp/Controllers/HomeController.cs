using Microsoft.AspNetCore.Mvc;
using Negocio.Exceptions;
using Negocio.LogicaAplicacion.DTOs;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.Usuario;
using NegocioWebApp.Filters;

namespace NegocioWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ILogin _loginCU;
        public HomeController(ILogin loginCU)
        {
            _loginCU = loginCU;

        }

        [FiltroAutenticado]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string mensaje)
        {
            ViewBag.Error = mensaje;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string contrasena)
        {
            try
            {
                UsuarioDTO logueado = _loginCU.Login(email, contrasena);
                HttpContext.Session.SetString("usuario", logueado.Nombre);
                HttpContext.Session.SetInt32("usuarioId", logueado.Id);
                return RedirectToAction("Index");
            }
            catch (UsuarioException ue)
            {
                ViewBag.Error = ue.Message;
                return View();
            }
            catch (Exception e)
            {
                ViewBag.Error = "Error inesperado.";
                return View();
            }
        }
    }
}
