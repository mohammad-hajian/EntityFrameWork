using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationOneToMany.Models
{
    class Country
    {
        public Country()
        {
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IList<State> States { get; set; }
    }
}
