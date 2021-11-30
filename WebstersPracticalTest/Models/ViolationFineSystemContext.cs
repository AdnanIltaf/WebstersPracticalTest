using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebstersPracticalTest.Models;

namespace WebstersPracticalTest.Entities
{
    public class ViolationFineSystemContext : DbContext
    {
        public ViolationFineSystemContext() : base("name=ViolationFineSystemWebsiteConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Fine> Fines { get; set; }
        public DbSet<Payments> Payment { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Violators> Violator { get; set; }
    }
}