using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Integrador.Models;

namespace Projeto_Integrador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        // Adicionar outras DbSet para outras tabelas, se necessário
    }
}
