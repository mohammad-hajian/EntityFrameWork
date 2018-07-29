using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace RelationOneToMany.Models
{
    class State
    {

        #region Configuration
        internal class Configuration : EntityTypeConfiguration<State>
        {
            public Configuration()
            {
                HasRequired(f => f.Country)
                    .WithMany(Country => Country.States)
                    .HasForeignKey(c => c.CountryID)
                    .WillCascadeOnDelete(false);
            }
        }

        #endregion

        public State()
        {
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
