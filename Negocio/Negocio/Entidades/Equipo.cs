using Negocio.Exceptions;
namespace Negocio.Entidades
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Equipo() { }
        public Equipo(string nombre)
        {
            this.Nombre = nombre;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(this.Nombre))
            {
                throw new EquipoException("El nombre del equipo no puede estar vacío");
            }
        }
    }
}
