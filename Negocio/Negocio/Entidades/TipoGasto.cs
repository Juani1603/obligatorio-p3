using Negocio.Exceptions;
namespace Negocio.Entidades
{
    public class TipoGasto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoGasto() { }
        public TipoGasto(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(this.Nombre) || string.IsNullOrEmpty(this.Descripcion))
            {
                throw new TipoGastoException("El nombre y la descripción son obligatorios.");
            }
        }
    }
}
