using Stunning.Model;
using Microsoft.EntityFrameworkCore;

namespace Stunnig.Data
{
    public class StunningContext : DbContext
    {
        public StunningContext(DbContextOptions<StunningContext> options) : base(options)
        {
        }

        public DbSet<Funcionarios> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionarios>().ToTable("Funcionarios");
        }

    }
}