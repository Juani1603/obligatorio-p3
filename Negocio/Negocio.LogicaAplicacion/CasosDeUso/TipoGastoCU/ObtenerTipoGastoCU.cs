using Negocio.InterfacesRepositorio;
using Negocio.LogicaAplicacion.DTOs;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.TipoGasto;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.LogicaAplicacion.Mappers;

namespace Negocio.LogicaAplicacion.CasosDeUso.TipoGastoCU
{
    public class ObtenerTipoGastoCU : IObtenerTipoGastos
    {
        private ITipoGastoRepositorio _repositorio;

        public ObtenerTipoGastoCU(ITipoGastoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<TipoGastoDTO> ObtenerTipoGastos()
        {
            IEnumerable<TipoGasto> retorno =
                _repositorio.FindAll();
            return retorno.Select(
                tp => TipoGastoMapper.ToDTO(tp)
            );
        }
    }
}
