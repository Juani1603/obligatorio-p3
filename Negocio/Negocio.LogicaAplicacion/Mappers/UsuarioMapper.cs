using Negocio.Entidades;
using Negocio.LogicaAplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LogicaAplicacion.Mappers
{
    public class UsuarioMapper
    {
        public static Usuario FromDTO(UsuarioDTO dto)
        {
            return new Usuario
            {
                Id = dto.Id,
                NombreCompleto = new ValueObjects.NombreCompleto(dto.Nombre, dto.Apellido),
                Contrasena = dto.Contrasena,
                Email = new ValueObjects.Email(dto.Email),
                Equipo = dto.Equipo,
                Rol = dto.Rol,
            };
        }
        public static UsuarioDTO ToDTO(Usuario usuario)
        {
            return new UsuarioDTO
            {
                Id = usuario.Id,
                Nombre = usuario.NombreCompleto.Nombre,
                Apellido = usuario.NombreCompleto.Apellido,
                Contrasena = usuario.Contrasena,
                Email = usuario.Email.Correo,
                Equipo = usuario.Equipo,
                Rol = usuario.Rol,
            };
        }
    }
}
