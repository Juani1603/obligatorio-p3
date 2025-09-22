using Microsoft.EntityFrameworkCore;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.EntityFramework
{
    public class NegocioContext : DbContext
    {
        public DbSet<TipoGasto> TipoGastos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        public NegocioContext(DbContextOptions options) : base(options) { }
    }
}
