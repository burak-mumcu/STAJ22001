﻿using Microservices.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
