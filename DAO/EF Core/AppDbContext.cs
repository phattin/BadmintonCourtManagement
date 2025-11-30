using DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.EF_Core
{
    public class AppDbContext : DbContext
    {
        public DbSet<StorageEntity.Storage> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;port=3306;database=badmintoncourtmanagement;uid=root;password=;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StorageEntity.Storage>()
            .Property(s => s.Status)
            .HasConversion<string>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
