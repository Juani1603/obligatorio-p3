using Negocio.Enum;

namespace Negocio.Entidades
{
    public class Recurrente : Pago
    {
        public int Id { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public Recurrente() : base() { }
        public Recurrente(MetodoPago metodoPago, TipoGasto tipoGasto, Usuario usuario, string descripcion,
                          double montoPago, DateTime fechaDesde, DateTime fechaHasta) : base(metodoPago, tipoGasto, usuario, descripcion, montoPago)
        {

            this.FechaDesde = fechaDesde;
            this.FechaHasta = fechaHasta;
        }
        public void Validar()
        {

        }
    }
}
