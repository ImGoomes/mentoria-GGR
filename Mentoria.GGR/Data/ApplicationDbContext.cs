using Mentoria.GGR.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria.GGR.Lib.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Poder> Poderes { get; set; }
        public DbSet<PersonagemHasPoder> PersonagemHasPoder { get; set; }

    }
}
