//App Name : Product Context   
//Author's Name : Kinjal Patel
//Student ID : 200334364    
//App Creation Date : 31 March, 2017
//App Description : It will Displays product Context file

namespace DollarComputers_Assignment4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsContextConnection")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
