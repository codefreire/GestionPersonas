using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionPersonas.Models
{
    public partial class PersonasDBContext : DbContext
    {
        public PersonasDBContext()
        {
        }

        public PersonasDBContext(DbContextOptions<PersonasDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK__Personas__B4ADFE39C30D94D9");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
