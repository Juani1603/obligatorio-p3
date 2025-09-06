using Negocio.Enum;

namespace Negocio.Entidades
{
    public class Unico : Pago
    {
        public DateTime FechaPago { get; set; }
        public int NroRecibo { get; set; }
        public Unico() : base() { }
        public Unico(MetodoPago metodoPago, TipoGasto tipoGasto, Usuario usuario, string descripcion,
                          double montoPago, DateTime fechaPago, int nroRecibo) : base(metodoPago, tipoGasto, usuario, descripcion, montoPago)
        {
            this.FechaPago = fechaPago;
            this.NroRecibo = nroRecibo;

        }

        public void Validar()
        {

        }
    }
}
