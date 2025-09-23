using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.LogicaAplicacion.DTOs;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.TipoGasto;
using NegocioWebApp.Filters;

namespace NegocioWebApp.Controllers
{
    public class TipoGastoController : Controller
    {
        private IAltaTipoGasto _altaTipoGasto;
        private IBorrarTipoGasto _borrarTipoGasto;
        private IEditarTipoGasto _editarTipoGasto;
        private IObtenerTipoGastos _obtenerTipoGastos;
        private IObtenerTipoGastoPorId _obtenerTipoGastoPorId;

       public TipoGastoController(
           IAltaTipoGasto altaTipoGasto,
           IBorrarTipoGasto borrarTipoGasto,
           IEditarTipoGasto editarTipoGasto,
           IObtenerTipoGastos obtenerTipoGastos,
           IObtenerTipoGastoPorId obtenerTipoGastoPorId)
        {
            _altaTipoGasto = altaTipoGasto;
            _borrarTipoGasto = borrarTipoGasto;
            _editarTipoGasto = editarTipoGasto;
            _obtenerTipoGastos = obtenerTipoGastos;
            _obtenerTipoGastoPorId = obtenerTipoGastoPorId;
        }

        // GET: TipoGastoController
        [FiltroRolAdministrador]
        public ActionResult Index()
        {
            return View(_obtenerTipoGastos.ObtenerTipoGastos());
        }

        // GET: TipoGastoController/Details/5
        [FiltroRolAdministrador]
        public ActionResult Details(int id)
        {
            return View(_obtenerTipoGastoPorId.BuscarTipoGastoPorId(id));
        }

        // GET: TipoGastoController/Create
        [FiltroRolAdministrador]
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
        [FiltroRolAdministrador]
        public ActionResult Edit(int id)
        {
            return View(_obtenerTipoGastoPorId.BuscarTipoGastoPorId(id));
        }   

        // POST: TipoGastoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TipoGastoDTO tp)
        {
            try
            {
                _editarTipoGasto.EditarTipoGasto(tp);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoGastoController/Delete/5
        [FiltroRolAdministrador]
        public ActionResult Delete(int id)
        {
            return View(_obtenerTipoGastoPorId.BuscarTipoGastoPorId(id));
        }

        // POST: TipoGastoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _borrarTipoGasto.BorrarTipoGasto(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
