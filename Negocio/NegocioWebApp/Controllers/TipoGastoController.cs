using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.LogicaAplicacion.DTOs;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.TipoGasto;

namespace NegocioWebApp.Controllers
{
    public class TipoGastoController : Controller
    {
        private IAltaTipoGasto _altaTipoGasto;
        private IObtenerTipoGastos _obtenerTipoGastos;

        public TipoGastoController(IAltaTipoGasto altaTipoGasto, IObtenerTipoGastos obtenerTipoGastos)
        {
            _altaTipoGasto = altaTipoGasto;
            _obtenerTipoGastos = obtenerTipoGastos;
        }


        // GET: TipoGastoController
        public ActionResult Index()
        {
            return View(_obtenerTipoGastos.ObtenerTipoGastos());
        }

        // GET: TipoGastoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoGastoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoGastoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoGastoDTO tipoGasto)
        {
            try
            {
                _altaTipoGasto.AgregarTipoGasto(tipoGasto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoGastoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoGastoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoGastoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoGastoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
