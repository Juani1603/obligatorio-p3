using AccesoDatos.EntityFramework;
using AccesoDatos.EntityFramework.Repositorios;
using Microsoft.EntityFrameworkCore;
using Negocio.InterfacesRepositorio;
using Negocio.LogicaAplicacion.CasosDeUso.TipoGastoCU;
using Negocio.LogicaAplicacion.CasosDeUso.UsuarioCU;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.TipoGasto;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.Usuario;

namespace NegocioWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSession();

            //Configuracion de Base de datos
            builder.Services.AddDbContext<NegocioContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("Negocio")
                )
            );

            //Inicialización de Repositorios
            builder.Services.AddScoped<ITipoGastoRepositorio, RepositorioTipoGastoEF>();
            builder.Services.AddScoped<IUsuarioRepositorio, RepositorioUsuarioEF>();

            //Inicialización de Casos de Uso
            //TipoGasto
            builder.Services.AddScoped<IAltaTipoGasto, AltaTipoGastoCU>();
            builder.Services.AddScoped<IBorrarTipoGasto, BorrarTipoGastoCU>();
            builder.Services.AddScoped<IEditarTipoGasto, EditarTipoGastoCU>();
            builder.Services.AddScoped<IObtenerTipoGastoPorId, ObtenerTipoGastoPorIdCU>();
            builder.Services.AddScoped<IObtenerTipoGastos, ObtenerTipoGastoCU>();
            //Usuario
            builder.Services.AddScoped<ILogin, LoginCU>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=TipoGasto}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
