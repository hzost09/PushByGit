using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WcfService1.Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string myconnect = ConfigurationManager.ConnectionStrings["myconnect"].ToString();
            optionsBuilder.UseSqlServer("Data Source=LInh;Initial Catalog=WCFdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductModel>().HasKey(p => p.Id);
        }
    }
}