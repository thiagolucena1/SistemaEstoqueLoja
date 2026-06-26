using EstoqueLojaV._0._2.Models.ClientesEntites;
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
        public DbSet<Cliente> Clientes { get; set; }  

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

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).HasMaxLength(100).IsRequired();
                entity.Property(e => e.CpfCnpj).HasMaxLength(18).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(150).IsRequired();
                entity.Property(e => e.Telefone).HasMaxLength(15).IsRequired();
                entity.Property(e => e.DataCadastro).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()").IsRequired();
                entity.Property(e => e.Ativo).HasDefaultValue(true).IsRequired();

                entity.HasIndex(e => e.CpfCnpj).IsUnique().HasDatabaseName("UQ_Cliente_CpfCnpj");
                entity.HasIndex(e => e.Email).IsUnique().HasDatabaseName("UQ_Cliente_Email");
            });
        }



    }
}
