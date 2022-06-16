using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Context
{
    public abstract class BaseDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        public BaseDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var rnd = new Random();
            optionsBuilder.UseInMemoryDatabase(rnd.Next().ToString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductOrder_ManyToMany(modelBuilder);

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            var products = new List<Product>()
            {
             new Product { ID = 1, Name="tt", Price=2.65m, Quantity=1},
             new Product { ID = 2, Name="rr", Price=2.65m, Quantity=1},
             new Product { ID = 3, Name="yy", Price=2.65m, Quantity=1}

            };

            var orders = new List<Order>()
            {
             new Order { ID = 1, Date="25/06/2022",SumPrice=25  },
               new Order { ID = 2, Date="25/07/2022",SumPrice=25  },
                 new Order { ID = 3, Date="25/08/2022",SumPrice=25  }

            };

            var productOrders = new List<ProductOrder>()
            {
                new ProductOrder { ProductId = 1, OrderId = 1  },
                  new ProductOrder { ProductId = 2, OrderId = 1  },
                    new ProductOrder { ProductId = 1, OrderId = 2  },
                      new ProductOrder { ProductId = 2, OrderId = 2  },
                        new ProductOrder { ProductId = 3, OrderId = 2 },
            };

            modelBuilder.Entity<User>().HasData(
     new User
     {
         ID = 1,
         Login = "admin",
         Password = "admin",
         IsAdmin = true
     },
         new User
         {
             ID = 2,
             Login = "user",
             Password = "user",
             IsAdmin = true
         });

            modelBuilder.Entity<Product>()
                .HasData(products[0], products[1], products[2]);

            modelBuilder.Entity<Order>()
                .HasData(orders[0], orders[1], orders[2]);

            modelBuilder.Entity<ProductOrder>()
            .HasData(productOrders[0], productOrders[1], productOrders[2], productOrders[3], productOrders[4]);
        }

        private void ProductOrder_ManyToMany(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOrder>()
          .HasKey(t => new { t.OrderId, t.ProductId });

            modelBuilder.Entity<Product>()
            .HasMany(p => p.Orders)
            .WithMany(p => p.Products)
            .UsingEntity<ProductOrder>(
        j => j
            .HasOne(x => x.Order)
            .WithMany(x => x.ProductOrders)
            .HasForeignKey(x => x.OrderId),

          j => j
            .HasOne(x => x.Product)
            .WithMany(x => x.ProductOrders)
            .HasForeignKey(x => x.ProductId));
        }

    }
}
