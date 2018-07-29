using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexType.Models;

namespace ComplexType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                Person person = new Person();
                person.GetFullName = new FullName("mohammad","hajian");
                Address address = new Address("iran");
                address.City = "esfahan";
                person.GetAddress = address;
                dataBaseContext.People.Add(person);
                dataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataBaseContext!=null)
                {
                    dataBaseContext.Dispose();
                    dataBaseContext = null;
                }
            }
        }
    }
}
