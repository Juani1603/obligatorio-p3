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
    public class EditarTipoGastoCU : IEditarTipoGasto
    {
        private ITipoGastoRepositorio _repositorio;
        
        public EditarTipoGastoCU(ITipoGastoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void EditarTipoGasto(TipoGastoDTO tipoGasto)
        {
            _repositorio.Update(TipoGastoMapper.FromDTO(tipoGasto));
        }
    }
}
