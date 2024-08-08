using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Ator> Ator { get; set; }
        public DbSet<Filme> Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=filmesapp2;Username=postgres;Password=postgres");
        }
    }
}
