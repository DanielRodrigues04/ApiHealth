
using Microsoft.EntityFrameworkCore;
using SaudeAPI.model;

namespace SaudeAPI.Data
{
    public class UsuarioContext : DbContext
    {
        
       public UsuarioContext (DbContextOptions<UsuarioContext> options) : base(options)
       {   
       }

        public DbSet<usuario> Usuarios {get; set;}
         
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            var usuario =  modelBuilder.Entity<usuario>();
            usuario.ToTable("tb_usuario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.DataNascimento).HasColumnName("data_nascimento");
        }
    }
}