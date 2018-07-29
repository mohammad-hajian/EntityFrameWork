using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ComplexType.Models
{
    class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }

        public DataBaseContext() : base("PersonsData")
        {
        }
        public DbSet<Person> People { get; set; }
    }
}
