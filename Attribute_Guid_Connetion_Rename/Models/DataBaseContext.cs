using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Attribute_Guid_Connetion_Rename.Models
{
    class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }

        public DataBaseContext() : base("CountrysData")
        {
        }
        public DbSet<Country> Countries { get; set; }
    }
}

