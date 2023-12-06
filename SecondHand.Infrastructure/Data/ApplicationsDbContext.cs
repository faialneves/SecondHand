using Microsoft.EntityFrameworkCore;
using SecondHand.Domain.Entities;

namespace SecondHand.Infrastructure.Data
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options) :base(options) 
        {
        }

        public DbSet<Itens> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Itens>().HasData();
        }
    }
}
