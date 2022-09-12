﻿using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
