using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationOneToOne.Models
{
    class Person
    {
        public Person()
        {

        }
        public int ID { get; set; }
        public String Name { get; set; }
        public virtual Address Address { get; set; }

    }
}
