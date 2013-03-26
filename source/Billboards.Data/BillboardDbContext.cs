using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Billboards.Data.Configuration;
using Billboards.Data.DataSet;
using Billboards.Model;
using System.ComponentModel.DataAnnotations;

namespace Billboards.Data
{

    public class BillboardDbContext : DbContext
    {
        //static BillboardDbContext()
        //{

        //}

        public BillboardDbContext()
            : base(nameOrConnectionString: "Billboard")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //    // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new BillboardConfiguration());

            modelBuilder.Entity<Billboard>()
                .Property(t => t.Timestamp)
                .IsRowVersion();

            modelBuilder.Entity<Address>()
                .Property(t => t.Timestamp)
                .IsRowVersion();

            base.OnModelCreating(modelBuilder);
        }

        // Model
        public DbSet<Billboard> Billboards { get; set; }

        // Lookup Lists
        public DbSet<Address> Addresses { get; set; }
    }
}
