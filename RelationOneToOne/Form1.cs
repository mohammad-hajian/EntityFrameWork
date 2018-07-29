using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelationOneToOne.Models;

namespace RelationOneToOne
{
    public partial class Form1 : Form
    {


        DataBaseContext GetDataBaseContext = null;


        #region Form

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region add Person

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataBaseContext = new DataBaseContext();
                Person person = null;

                person = new Person()
                {
                    Name = "mohammad hajian"
                };
                GetDataBaseContext.People.Add(person);
                person = new Person()
                {
                    Name = "Ali baghery",
                    Address = new Address()
                    {
                        Country = "Iran",
                        State = "Isfahan",
                        City = "Kashan"
                    }
                };
                GetDataBaseContext.People.Add(person);
                GetDataBaseContext.SaveChanges();

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

        }
        #endregion


        #region Add person In Address

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataBaseContext = new DataBaseContext();

                var person = GetDataBaseContext.People.Include("Address").Where(c => c.Name.Contains("Ali")).ToList();
                listBox1.DataSource = person;
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "ID";

                textBox1.Text = person[0].Address.Disp;
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }
        #endregion


        #region Add Address In Person

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataBaseContext = new DataBaseContext();
                var adres = GetDataBaseContext.Addresses.Include("person").Where(b => b.Country.Contains("Iran")).ToList();

                List<Person> lperson = new List<Person>()
                {
                    adres[0].person
                };
                listBox1.DataSource = lperson;
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "ID";

                textBox1.Text = adres[0].Disp;

            }
            catch (Exception rt)
            {

                MessageBox.Show(rt.Message);
            }

        }

        #endregion


        #region CloseForm
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GetDataBaseContext != null)
            {
                GetDataBaseContext.Dispose();
                GetDataBaseContext = null;
            }
        }

        #endregion


    }
}
