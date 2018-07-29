using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Casting.Models
{
    
    class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseContextInitializer());
        }
        public DataBaseContext() : base("MyCountry")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new State.Configuration());
            modelBuilder.Configurations.Add(new Country.Configuration());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}
