﻿using BdaUai.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BdaUai.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros{ get; set; }
        public DbSet<Venta> Ventas{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>().HasIndex(c=> c.Nombre).IsUnique();
        }
    }
}
