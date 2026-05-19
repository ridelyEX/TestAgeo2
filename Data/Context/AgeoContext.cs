using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities.Personas;

namespace Data.Context
{
    public class AgeoContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder temporal de persona, corrección próxima
            modelBuilder.Entity<Persona>()
                .HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
