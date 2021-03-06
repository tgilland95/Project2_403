﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2_403.Models
{
    public class RepairsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RepairsContext() : base("DefaultConnection")
        {
        }
        public DbSet<DeviceReference> deviceReference { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<RepairInfoModel> RepairInfoRecords { get; set; }
        public DbSet<CustomerInfoModel> CustomerInfoRecords { get; set; }
        public DbSet<RepairRecord> Repair { get; set; }

    }
}
