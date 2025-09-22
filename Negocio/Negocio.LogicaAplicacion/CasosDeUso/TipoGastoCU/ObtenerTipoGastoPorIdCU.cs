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
    public class ObtenerTipoGastoPorIdCU : IObtenerTipoGastoPorId
    {
        private ITipoGastoRepositorio _repositorio;

        public ObtenerTipoGastoPorIdCU(ITipoGastoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public TipoGastoDTO BuscarTipoGastoPorId(int id)
        {
            return TipoGastoMapper.ToDTO(_repositorio.FindById(id));
        }
    }
}
