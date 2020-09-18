using Microsoft.EntityFrameworkCore;
using OT.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OT.DAL.Context
{
    public class OTContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=KapitalOT_Db;integrated security=true;");
        }
        public DbSet<User> Users { get; set; }
    }
}
