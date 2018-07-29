using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attribute_Guid_Connetion_Rename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Models.DataBaseContext odataBaseContext = null;
            try
            {
                odataBaseContext = new Models.DataBaseContext();
                Models.Country ocountry = null;
                ocountry = new Models.Country("iran");
                odataBaseContext.Countries.Add(ocountry);
                odataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (odataBaseContext != null)
                {
                    odataBaseContext.Dispose();
                    odataBaseContext = null;
                }
            }
        }
    }
}
