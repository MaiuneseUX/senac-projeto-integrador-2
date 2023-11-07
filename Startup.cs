using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projeto_Integrador.Controllers;
using Projeto_Integrador.Data;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Integrador

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
             // Configurar a conexão com o banco de dados MySQL
            string connectionString = Configuration.GetConnectionString("MySqlConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(connectionString));

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // Adicione essa linha para habilitar a autenticação

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Usuarios}/{action=Login}/{id?}"); // Defina a rota padrão para a página de login

                endpoints.MapControllerRoute(
                    name: "Jogos",
                    pattern: "{controller=Jogos}/{action=Index}/{id?}");
            });
        }
    }
}
