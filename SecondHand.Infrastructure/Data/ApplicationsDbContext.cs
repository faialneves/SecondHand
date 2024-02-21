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

            modelBuilder.Entity<Itens>().HasData(new Itens
            {
                Id = 1,
                Name = "Vintage Leather Jacket",
                Description = "Classic black leather jacket with a vintage look.",
                ImageUrl = "https://placehold.co/600x400",
                Price = 150,
            },

    new Itens
    {
        Id = 2,
        Name = "Antique Pocket Watch",
        Description = "Beautifully crafted pocket watch from the 19th century.",
        ImageUrl = "https://placehold.co/600x401",
        Price = 200,
    },
    new Itens
    {
        Id = 3,
        Name = "Retro Vinyl Records",
        Description = "Collection of various music genres on vinyl records.",
        Price = 50,
    }
);
        }
    }
}
