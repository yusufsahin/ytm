
using Microsoft.EntityFrameworkCore;
using Storium.Domain.Categories;
using Storium.Domain.Orders;
using Storium.Domain.Products;
using Storium.Domain.Shared;
using Storium.Domain.Users;

namespace Storium.Infrastructure.Context
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product>  Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User>  Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=StoriumDb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

            modelBuilder.Entity<User>()
               .Property(p => p.Email)
               .HasConversion(email => email.Value, value => new(value));

            modelBuilder.Entity<User>()
               .Property(p => p.Password)
               .HasConversion(password => password.Value, value => new(value));

            modelBuilder.Entity<User>()
                .OwnsOne(p => p.Address);

            modelBuilder.Entity<Category>()
                .Property(p => p.Name)
                .HasConversion(name => name.Value, value => new(value));

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasConversion(name => name.Value, value => new(value));

            modelBuilder.Entity<Product>()
                .OwnsOne(p => p.Price, priceBuilder =>
                {
                    priceBuilder
                    .Property(p => p.Currency)
                    .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                    priceBuilder
                    .Property(p => p.Amount)
                    .HasColumnType("money");
                });

            modelBuilder.Entity<OrderLine>()
                .OwnsOne(p => p.Price, priceBuilder =>
                {
                    priceBuilder
                    .Property(p => p.Currency)
                    .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                    priceBuilder
                    .Property(p => p.Amount)
                    .HasColumnType("money");
                });
        }
    }
}
