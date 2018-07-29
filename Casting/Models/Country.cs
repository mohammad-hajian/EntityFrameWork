using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Casting.Models
{
    class Country
    {

        #region Configuration
        public class Configuration : EntityTypeConfiguration<Country>
        {
            public Configuration()
            {

            }
        }
        #endregion

        public Country()
        {

        }
        public Country(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; private set; }
        public string Name { get; set; }
        public virtual IList<State> States { get; set; }
    }
}
