using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelationManyToMany.Models;

namespace RelationManyToMany.Models
{
    class User
    {
        public User()
        {
        }
        public int ID { get;private set; }
        public string Name { get; set; }

        public virtual IList<Group> Groups { get; set; }
    }
}
