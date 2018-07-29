using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace RelationOneToOne.Models
{
    class Address
    {

        internal class Configuration:EntityTypeConfiguration<Address>
        {
            public Configuration()
            {
                HasKey(c => c.PersonID).HasRequired(c => c.person).WithOptional(Person => Person.Address).WillCascadeOnDelete(true);
            }
        }

        public Address()
        {

        }
        public int PersonID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public virtual Person person { get; set; }

        public string Disp {
            get
            {
                return string.Format($"{Country} -  {State}  -  {City}");
            }
        }
    }
}
