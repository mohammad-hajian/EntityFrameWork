using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Edition
{
    public partial class Form1 : Form
    {
        #region form1
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }
        #endregion




        #region Button_Add_Click
        private void Button_Add_Click(object sender, EventArgs e)
        {
            Models.DataBaseContext ODataBaseContext = null;
            try
            {
                ODataBaseContext = new Models.DataBaseContext();
                Models.Country OCountry = new Models.Country();
                OCountry.Name = textBox1.Text.Trim();
                ODataBaseContext.Countries.Add(OCountry);
                ODataBaseContext.SaveChanges();
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ODataBaseContext != null)
                {
                    ODataBaseContext.Dispose();
                    ODataBaseContext = null;
                }
            }

        }
        #endregion




        #region Button_Show_Click
        private void Button_Show_Click(object sender, EventArgs e)
        {
            Display();
        }
        #endregion




        #region Button_Delete_Click
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Models.DataBaseContext ODataBaseContext = null;
            try
            {
                ODataBaseContext = new Models.DataBaseContext();
                ODataBaseContext.Countries.Load();
                ODataBaseContext.Countries.Local.Clear();
                ODataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ODataBaseContext != null)
                {
                    ODataBaseContext.Dispose();
                    ODataBaseContext = null;
                }
            }
        }
        #endregion




        #region Button_DeleteName_Click
        private void Button_DeleteName_Click(object sender, EventArgs e)
        {
            Models.DataBaseContext ODataBaseContext = null;
            try
            {
                ODataBaseContext = new Models.DataBaseContext();
                var VarCountry = ODataBaseContext.Countries.FirstOrDefault(c => c.Name == textBox1.Text);
                ODataBaseContext.Countries.Remove(VarCountry);
                ODataBaseContext.SaveChanges();
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ODataBaseContext != null)
                {
                    ODataBaseContext.Dispose();
                    ODataBaseContext = null;
                }
            }
        }
        #endregion




        #region Button_Check
        private void Button_Check_Click(object sender, EventArgs e)
        {
            Models.DataBaseContext ODataBaseContext= new Models.DataBaseContext();
            ODataBaseContext.Countries.OrderBy(c => c.Name).Load();
            var VarOrder = ODataBaseContext.Countries.Local;
            MessageBox.Show($"تعداد : {VarOrder.Count}");

            Models.Country ODeletedCountry = VarOrder[0];
            MessageBox.Show($" وضعیت کشور اولی به ترتیب نام: {ODataBaseContext.Entry(ODeletedCountry).State.ToString()}");
            VarOrder.RemoveAt(0);
            //ODataBaseContext.SaveChanges();
            MessageBox.Show($"وضعیت دوباره آن : {ODataBaseContext.Entry(ODeletedCountry).State.ToString()}");

            Models.Country ONewCountry = new Models.Country();
            ONewCountry.Name = "akbar joojeh";
            MessageBox.Show($"وضعیت کشور تازه ساخته شده : {ODataBaseContext.Entry(ONewCountry).State.ToString()}");

            ODataBaseContext.Countries.Add(ONewCountry);
            MessageBox.Show($"وضعیت کشور تازه ساخته شده اضافه شده : {ODataBaseContext.Entry(ONewCountry).State.ToString()}");



            string StrName = VarOrder[0].Name;
            VarOrder[0].Name = StrName;
            MessageBox.Show($"وضعیت کشوری که نامش تغییر کرده ولی به خودش تبدیل شده : {ODataBaseContext.Entry(VarOrder[0]).State.ToString()}");

            VarOrder[0].Name = "ali";
            MessageBox.Show($"وضعیت کشوری که نامش تغییر کرده و به نام دیگری تبدیل شده : {ODataBaseContext.Entry(VarOrder[0]).State.ToString()}");

            VarOrder[0].Name = StrName;
            MessageBox.Show($"وضعیت کشوری که نامش تغییر کرده و دوباره  به نام خودش تبدیل شده : {ODataBaseContext.Entry(VarOrder[0]).State.ToString()}");
        }

        #endregion




        #region Display
        public void Display()
        {
            Models.DataBaseContext ODataBaseContext = null;
            try
            {
                ODataBaseContext = new Models.DataBaseContext();
                var VarList = ODataBaseContext.Countries.ToList();
                listBox1.DataSource = VarList;
                listBox1.DisplayMember = "DisplayName";
                listBox1.ValueMember = "ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ODataBaseContext != null)
                {
                    ODataBaseContext.Dispose();
                    ODataBaseContext = null;
                }
            }

        }
    }
    #endregion
}
