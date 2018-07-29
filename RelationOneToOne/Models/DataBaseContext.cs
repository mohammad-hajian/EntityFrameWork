using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RelationOneToOne.Models
{
    class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }

        public DataBaseContext():base("MyPerson")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Address.Configuration());
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
