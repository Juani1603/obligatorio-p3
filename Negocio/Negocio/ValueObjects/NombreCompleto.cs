using Negocio.Exceptions;
namespace Negocio.ValueObjects
{
    public class NombreCompleto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public NombreCompleto() { }
        public NombreCompleto(string Nombre, string Apellido)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Validar();
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(this.Nombre) || string.IsNullOrEmpty(this.Apellido))
            {
                throw new UsuarioException("El nombre y el apellido no pueden estar vacíos.");
            }
        }
    }
}
