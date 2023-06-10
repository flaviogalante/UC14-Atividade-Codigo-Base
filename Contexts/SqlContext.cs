using Chapter16.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Chapter16.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext() 
        { 
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) 
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão foi depende da SUA máquina.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-JDSD230\\SQLEXPRESS; initial catalog = Chapter16; Integrated Security = true");
                // Exemplo 1 de string de conexão:
                // User ID=sa;Password=admin;Server=localhost;Database=Chapter;-
                // + Trusted_Connection=False;
                // Exemplo 2 de string de conexão:
                //Server=localhost\\SQLEXPRESS;Database=Chapter;Trusted_Connection=True;
            }
        }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
