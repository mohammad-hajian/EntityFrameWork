using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Casting.Models
{
    class DataBaseContextInitializer:DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        public DataBaseContextInitializer()
        {
        }
    

        protected override void Seed(DataBaseContext databasecontext)
        {
            base.Seed(databasecontext);
            Country country = null;
            country = new Country(1, "iran")
            {
                States = new List<State>()
                {
                    new State(1,"isfahan"),
                    new State(2,"tehran"),
                    new State(3,"shiraz")
                }
            };
            databasecontext.Countries.Add(country);

            country = new Country(2, "france");
            country.States = new List<State>();
            country.States.Add(new State(4, "goobli"));
            country.States.Add(new State(5, "foody"));
            databasecontext.Countries.Add(country);

            country = new Country(3, "iraq");
            country.States = new List<State>();
            country.States.Add(new State(6, "karbala"));
            country.States.Add(new State(7, "najaf"));
            databasecontext.Countries.Add(country);
            databasecontext.SaveChanges();
        }
    }
}
