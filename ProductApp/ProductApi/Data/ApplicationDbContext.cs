using Microsoft.EntityFrameworkCore;

namespace ProductApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "PlayStation 5",
                    Description = "Console Sony PlayStation 5, SSD 825GB, DualSense incluso",
                    Price = 4499.00m,
                    Stock = 12
                },
                new Product
                {
                    Id = 2,
                    Name = "Xbox Series X",
                    Description = "Console Microsoft Xbox Series X, SSD 1TB, controle sem fio",
                    Price = 4299.00m,
                    Stock = 10
                },
                new Product
                {
                    Id = 3,
                    Name = "Nintendo Switch OLED",
                    Description = "Console híbrido Nintendo Switch OLED, 64GB, Joy-Con branco",
                    Price = 2599.00m,
                    Stock = 18
                },
                new Product
                {
                    Id = 4,
                    Name = "Super Nintendo (SNES)",
                    Description = "Console Super Nintendo, 2 controles, 21 jogos embutidos",
                    Price = 899.00m,
                    Stock = 8
                },
                new Product
                {
                    Id = 5,
                    Name = "PlayStation 2",
                    Description = "Console Sony PlayStation 2, leitor DVD, 1 controle DualShock 2",
                    Price = 650.00m,
                    Stock = 6
                }
            );
        }
    }
}