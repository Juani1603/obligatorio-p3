using Negocio.InterfacesRepositorio;
using Negocio.LogicaAplicacion.DTOs;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.TipoGasto;
using Negocio.LogicaAplicacion.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LogicaAplicacion.CasosDeUso.TipoGastoCU
{
    public class BorrarTipoGastoCU : IBorrarTipoGasto
    {
        private ITipoGastoRepositorio _repositorio;
        public BorrarTipoGastoCU(ITipoGastoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void BorrarTipoGasto(int id)
        {
            _repositorio.Remove(id);
        }
    }
}
