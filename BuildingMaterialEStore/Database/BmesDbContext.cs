﻿using BuildingMaterialEStore.Messages.Requests.Order;
using BuildingMaterialEStore.Models.Address;
using BuildingMaterialEStore.Models.Cart;
using BuildingMaterialEStore.Models.Customer;
using BuildingMaterialEStore.Models.Product;
using BuildingMaterialEStore.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace BuildingMaterialEStore.Database
{
    public class BmesDbContext : DbContext 
    {
        public BmesDbContext(DbContextOptions<BmesDbContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
