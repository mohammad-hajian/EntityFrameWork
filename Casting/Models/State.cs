using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Casting.Models
{

    class State
    {

        #region Configuration
        /// <summary>
        /// Fluent API
        /// </summary>
        internal class Configuration : EntityTypeConfiguration<State>
        {
            public Configuration()
            {
                HasRequired(c => c.Country)
                    .WithMany(Country => Country.States)
                    .HasForeignKey(c => c.CountryID)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        public State()
        {

        }
        public State(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; private set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
