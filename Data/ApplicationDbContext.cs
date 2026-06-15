using EstoqueLojaV._0._2.Models.Log;
using Microsoft.EntityFrameworkCore;

namespace EstoqueLojaV._0._2.Data
{
    public class ApplicationDbContext : DbContext // Ponte entre a aplicação e o banco de dados, usando Entity Framework Core
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<LogAuditoria> LogsAuditoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LogAuditoria>(entity =>
            {
                entity.ToTable("LogAuditoria");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Acao).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Entidade).HasMaxLength(100).IsRequired();
                entity.Property(e => e.IpUsuario).HasMaxLength(45).IsRequired();
                entity.Property(e => e.Usuario).HasMaxLength(150);
                entity.Property(e => e.UsuarioRole).HasMaxLength(100);

                entity.HasIndex(e => e.Horario);
            });
        }



    }
}
