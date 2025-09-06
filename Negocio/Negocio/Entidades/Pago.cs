using Negocio.Enum;
using Negocio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    abstract public class Pago
    {
        public MetodoPago MetodoPago { get; set; }
        public TipoGasto TipoGasto { get; set; }
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
        public double MontoPago { get; set; }
        public Pago() { }
        public Pago(MetodoPago metodoPago, TipoGasto tipoGasto, Usuario usuario, string descripcion, double montoPago)
        {
            this.MetodoPago = metodoPago;
            this.TipoGasto = tipoGasto;
            this.Usuario = usuario;
            this.Descripcion = descripcion;
            this.MontoPago = montoPago;
        }

        public void Validar()
        {
            if (TipoGasto == null || Usuario == null || string.IsNullOrEmpty(this.Descripcion) || MontoPago < 0)
            {
                throw new PagoException("El tipo de gasto, el usuario, la descripción y el monto de pago son obligatorios.");
            }
        }
    }
}
