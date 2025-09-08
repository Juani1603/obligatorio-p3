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
    public class AltaTipoGastoCU : IAltaTipoGasto
    {
        private ITipoGastoRepositorio _repositorio;

        public AltaTipoGastoCU(ITipoGastoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AgregarTipoGasto(TipoGastoDTO tipoGasto)
        {
            _repositorio.Add(TipoGastoMapper.FromDTO(tipoGasto));
        }
    }
}
