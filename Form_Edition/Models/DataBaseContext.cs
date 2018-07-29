using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Form_Edition.Models
{
    class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }
        public DataBaseContext():base("MyCountries")
        {
        }
        public DbSet<Country> Countries { get; set; }
    }
}
