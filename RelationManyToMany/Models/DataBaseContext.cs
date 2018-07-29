using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelationManyToMany.Models;
using System.Data.Entity;

namespace RelationManyToMany.Models
{
    class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }
        public DataBaseContext():base("MyGroups")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new Group.Configuration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
