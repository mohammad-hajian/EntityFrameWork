using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casting.Models;

namespace Casting
{


    public partial class Casting : Form
    {
        #region Form
        public Casting()
        {
            InitializeComponent();
        }
        DataBaseContext databasecontext ;

        private void Casting_Load(object sender, EventArgs e)
        {
            try
            {
                //نیو نمودن شی دیتا بیس کانتکست
                databasecontext =
                    new DataBaseContext();

                // ایجاد یک متغیر از جنس ور که حاوی کشور هاست
                var varCountries =
                    databasecontext.Countries
                    .ToList()
                    ;
                //تنظیمات لیست کانتری
                listBoxCountry.ValueMember = "ID";
                listBoxCountry.DisplayMember = "Name";
                //کشور ها به لیست بایند میشود
                listBoxCountry.DataSource = varCountries;
            }
            //در صورت بروز خطا آن را نمایش میدهیم
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Select
        private void listBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var Country = listBoxCountry.SelectedItem as Country;

                if (Country != null)
                {
                    //var a = Country.ID;
                    //var state = databasecontext.States.Where(c => c.CountryID == a).ToList();
                   var countrY= databasecontext.Countries.Include("States").Where(c => c.ID == Country.ID).FirstOrDefault();
                    listBoxState.ValueMember = "ID";
                    listBoxState.DisplayMember = "Name";
                    //لیست استان ها بایند میشود با پراپرتی استان شی کشور
                    listBoxState.DataSource =countrY.States ;
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }
        #endregion

        #region Close
        private void Casting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (databasecontext != null)
            {
                databasecontext.Dispose();
                databasecontext = null;
            }
        }
        #endregion

    }
}
