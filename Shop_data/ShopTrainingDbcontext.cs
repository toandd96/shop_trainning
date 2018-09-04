﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Model.Models;

namespace Shop_data
{
    public class ShopTrainingDbcontext:DbContext
    {
        public ShopTrainingDbcontext() : base("ShopTrainingConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }
    }
}
