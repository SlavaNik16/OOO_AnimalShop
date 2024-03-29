﻿using OOO_AnimalShop.Context.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_AnimalShop.Context
{
    public class AnimalShopContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTypes> ProductTypeses { get; set; }
        public DbSet<PunktVidachi> PunktVidachis { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public AnimalShopContext() : base("ConString")
        {
        }
    }
}
