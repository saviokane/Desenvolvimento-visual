﻿using Microsoft.EntityFrameworkCore;
using PetCafes.Models;


namespace PetCafes.Data
{
    public class PetCafeDbContext : DbContext
    {
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Produto>? Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=petCafe.db;Cache=Shared");
        }
    }
}