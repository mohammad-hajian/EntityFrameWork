using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelationManyToMany.Models;
using System.Data.Entity.ModelConfiguration;

namespace RelationManyToMany.Models
{
    class Group
    {

        #region Configuration
        internal class Configuration : EntityTypeConfiguration<Group>
        {
            public Configuration()
            {
                HasMany(c => c.Users)
                    .WithMany(User => User.Groups)
                    .Map(c =>
                    {
                        c.ToTable("UsersInGroups");
                        c.MapLeftKey("GroupID");
                        c.MapRightKey("UserID");
                    });

            }
        }
        #endregion


        public Group()
        {
        }
        public int ID { get; private set; }
        public string Name { get; set; }

        public virtual IList<User> Users { get; set; }
    }
}
