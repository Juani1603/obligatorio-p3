using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;
using Negocio.LogicaAplicacion.DTOs;

namespace Negocio.LogicaAplicacion.Mappers
{
    public class TipoGastoMapper
    {
        public static TipoGasto FromDTO(TipoGastoDTO dto)
        {
            return new TipoGasto
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion
            };
        }

        public static TipoGastoDTO ToDTO(TipoGasto tipoGasto)
        {
            return new TipoGastoDTO
            {
                Nombre = tipoGasto.Nombre,
                Descripcion = tipoGasto.Descripcion
            };
        }
    }
}
