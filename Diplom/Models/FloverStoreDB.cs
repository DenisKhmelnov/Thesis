using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Diplom.Models
{
    public class FloverStoreDB : DbContext
    {
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<StorePosition> StorePositions { get; set; }

        public DbSet<Cart> Carts { get; set; }
    }
}