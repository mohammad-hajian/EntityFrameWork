using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelationManyToMany.Models;

namespace RelationManyToMany
{
    public partial class Form : System.Windows.Forms.Form
    {
        DataBaseContext databasecontext = null;


        #region Form
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region button_Record_Click

        private void button_Record_Click(object sender, EventArgs e)
        {

            try
            {
                databasecontext = new DataBaseContext();
                Group group = null;
                User user = null;

                group = new Group()
                {
                    Name = "Group1"
                };
                databasecontext.Groups.Add(group);
                group = new Group()
                {
                    Name = "Group2"
                };
                databasecontext.Groups.Add(group);

                group = new Group()
                {
                    Name = "Group3"
                };
                databasecontext.Groups.Add(group);

                user = new User()
                {
                    Name = "User1"
                };
                databasecontext.Users.Add(user);
                user = new User()
                {
                    Name = "User2"
                };
                databasecontext.Users.Add(user);
                databasecontext.SaveChanges();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            finally
            {
                if (databasecontext != null)
                {
                    databasecontext.Dispose();
                    databasecontext = null;
                }
            }
        }
        #endregion


        private void button_Add_Groups_Click(object sender, EventArgs e)
        {
            databasecontext = new DataBaseContext();

            try
            {
                var Group1 = databasecontext.Groups.Where(c => c.Name == "Group1").FirstOrDefault();
                var Group2 = databasecontext.Groups.Where(c => c.Name == "Group2").FirstOrDefault();
                var User1 = databasecontext.Users.Where(c => c.Name == "User1").FirstOrDefault();

                User1.Groups = new List<Group>();

                User1.Groups.Add(Group1);
                User1.Groups.Add(Group2);

                //databasecontext.Users.Add(User1);      اگر اینکار رو بکنیم یه یوزر دیگه ساخته میشه
                databasecontext.SaveChanges();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            finally
            {
                if (databasecontext != null)
                {
                    databasecontext.Dispose();
                    databasecontext = null;
                }
            }

        }

        private void button_Add_Users_Click(object sender, EventArgs e)
        {
            databasecontext = new DataBaseContext();

            try
            {
                var Group3 = databasecontext.Groups.Where(c => c.Name == "Group3").FirstOrDefault();
                var User1 = databasecontext.Users.Where(c => c.Name == "User1").FirstOrDefault();
                var User2 = databasecontext.Users.Where(c => c.Name == "User2").FirstOrDefault();

                Group3.Users = new List<User>();

                Group3.Users.Add(User1);
                Group3.Users.Add(User2);
                   
                //databasecontext.Groups.Add(Group3);       اگر اینکار رو بکنیم یه گروپ دیگه ساخته میشه
                databasecontext.SaveChanges();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            finally
            {
                if (databasecontext != null)
                {
                    databasecontext.Dispose();
                    databasecontext = null;
                }
            }
        }
    }
}
