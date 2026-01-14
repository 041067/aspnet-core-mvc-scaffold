using aspnet_core_mvc_scaffold.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_mvc_scaffold.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("ClientesTB");
            modelBuilder.Entity<Categoria>().ToTable("CategoriasTB");
            modelBuilder.Entity<Produto>().ToTable("ProdutosTB");
        }
    }
}