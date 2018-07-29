using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelationOneToMany.Models;

namespace RelationOneToMany
{
    public partial class Form1 : Form
    {
        #region form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #endregion



        #region Add
        private void Button_Add_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                Country country = new Country()
                {
                    Name = "iran"
                };
                dataBaseContext.Countries.Add(country);
                dataBaseContext.SaveChanges();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            finally
            {
                if (dataBaseContext != null)
                {
                    dataBaseContext.Dispose();
                    dataBaseContext = null;
                }
            }
        }
        #endregion



        #region Something
        private void Button_Do_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                var country = dataBaseContext.Countries.FirstOrDefault(c => c.ID == 1);
                if (country == null)
                {
                    return;
                }
                State state = null;

                state = new State();
                state.Name = "isfahan";
                country.States = new List<State>
                {
                    state
                };
                //dataBaseContext.Countries.Add(country);     اگر اینکار رو بکنیم یه کانتری دیگه ساخته میشه

                state = new State
                {
                    Name = "shiraz",
                    CountryID = country.ID
                };
                dataBaseContext.States.Add(state);


                state = new State
                {
                    Name = "tehran",
                    Country = country
                };
                dataBaseContext.States.Add(state);


                dataBaseContext.SaveChanges();


            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            finally
            {
                if (dataBaseContext != null)
                {
                    dataBaseContext.Dispose();
                    dataBaseContext = null;
                }
            }

        }
        #endregion
    }
}
