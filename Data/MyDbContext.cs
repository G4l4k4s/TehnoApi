using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStoreApi.Models;

namespace TechStoreApi.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<OrderItem> OrderItems {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Category> Categorys {get; set;}
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}