using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }


        bool validateFiels()
        {
            if(Validations.IsNull(tbxCredentials.Text) || Validations.IsNull(tbxPassword.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void LoginTenantWithEmail(string email)
        {
            var data = (from tenant in db.Tenants where tenant.Email == email select new { tenant.Password, tenant.Email, tenant.TenantID,tenant.FirstName}).ToList();
            if (data.Count == 0)
            { 
                    MessageBox.Show("Invalid credentials");
                    return;
            }

            string hashedPassword = data[0].Password;
            if (PasswordManager.verifyPassword(tbxPassword.Text, hashedPassword))
            {
                LogedTenant.TenantID = data[0].TenantID;
                LogedTenant.Email = data[0].Email;
                LogedTenant.TenantName = data[0].FirstName;
                LogedUser.IsLogin = true;

                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Invalid Credential");
            }
            this.Close();

        }

        void LoginUserWithUsername(string userName)
        {
            var data = db.Login(userName,null).ToList();

            if (data.Count == 0)
            {
                MessageBox.Show("Invalid credentials");
                return;
            }

            string hashedPassword = data[0].PasswordHash;
            if (PasswordManager.verifyPassword(tbxPassword.Text, hashedPassword))
            {
                if (data[0].StaffID != null)
                {
                    int id = (int) data[0].StaffID;
                    var logedData = (from user in db.Users
                                     join staff in db.Staffs on user.StaffID equals staff.StaffID where user.StaffID == id
                                     select new { user.UserID, user.UserName, staff.PositionID }
                                     ).ToList();

                    if (logedData.Count > 0)
                    {
                        LogedUser.UserID = logedData[0].UserID;
                        LogedUser.UserName = logedData[0].UserName;
                        var getPos = db.getPosition(logedData[0].PositionID).ToList();
                        LogedUser.Position = getPos.FirstOrDefault();
                        LogedUser.IsLogin = true;
                    }
                    MessageBox.Show("Success");
                }
                else
                {
                    var logedData = (from user in db.Users where user.UserName == tbxCredentials.Text
                                     select new { user.UserID, user.UserName}
                                                        ).ToList();

                    if (logedData.Count > 0)
                    {
                        LogedUser.UserID = logedData[0].UserID;
                        LogedUser.UserName = logedData[0].UserName;
                        LogedUser.IsLogin = true;
                        LogedUser.IsAdmin = true;
                    }
                    MessageBox.Show("Success");
                }
            }
            else
            {
                MessageBox.Show("Invalid Credential");
            }
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateFiels())
                {
                    if (Validations.ValidateEmail(tbxCredentials.Text))
                    {
                        LoginTenantWithEmail(tbxCredentials.Text);
                    }
                    else
                    {
                        LoginUserWithUsername(tbxCredentials.Text);

                    }
                }
                else
                {
                    MessageBox.Show("Fields are Required....");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
            }
        }
    }
}
