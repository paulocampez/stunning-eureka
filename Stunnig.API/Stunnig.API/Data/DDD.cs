using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stunning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stunnig.API.Models
{
    public class DDD
    {
        public partial class Funcionario
        {
            public Funcionario()
            {

            }
            public Funcionario(int? idFuncionario)
            {
                IdFuncionario = idFuncionario;
            }
            public int? IdFuncionario { get; set; }
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public DateTime? DataCad { get; set; }
            public string Cargo { get; set; } //TODO: Enum
            public string UfNasc { get; set; }
            public decimal? Salario { get; set; }
            public string Status { get; set; } //TODO: Enum
        }

        public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
        {
            public void Configure(EntityTypeBuilder<Funcionario> builder)
            {
                builder.ToTable("Funcionarios", "Empresa");

                //PK da entidade
                builder.HasKey(p => p.IdFuncionario);

                builder.Property(p => p.Nome).HasColumnType("nvarchar(200)").IsRequired();
                builder.Property(p => p.Cpf).HasColumnType("nvarchar(200)").IsRequired();
                builder.Property(p => p.DataCad).HasColumnType("datetime2").IsRequired();
                builder.Property(p => p.Cargo).HasColumnType("nvarchar(200)").IsRequired();
                builder.Property(p => p.UfNasc).HasColumnType("nvarchar(2)").IsRequired();
                builder.Property(p => p.Salario).HasColumnType("decimal(18, 2)").IsRequired();
                builder.Property(p => p.Status).HasColumnType("nvarchar(200)").IsRequired();


                builder
               .Property(p => p.IdFuncionario)
               .HasColumnType("int")
               .IsRequired()
               .HasComputedColumnSql("NEXT VALUE FOR [Sequences].[StockItemID]");


                throw new NotImplementedException();
            }
        }

        public class StunningDbContext : DbContext
        {
            public StunningDbContext(DbContextOptions<StunningDbContext> options) : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());

                base.OnModelCreating(modelBuilder);

            }
            public DbSet<Funcionarios> Funcionarios { get; set; }
        }
    }
}
