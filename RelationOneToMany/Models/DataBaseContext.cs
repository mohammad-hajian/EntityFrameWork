using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RelationOneToMany.Models
{
    class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }
        public DataBaseContext():base("My Countries")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new State.Configuration());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

    }
}
