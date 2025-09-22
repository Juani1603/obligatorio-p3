using Negocio.LogicaAplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.TipoGasto
{
    public interface IBorrarTipoGasto
    {
        public void BorrarTipoGasto(int id);
    }
}
