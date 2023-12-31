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
    public partial class TenantsForm : Form
    {
        public TenantsForm()
        {
            InitializeComponent();
        }
        int randomPassword()
        {
            Random random = new Random();
            
            return random.Next(1000, 10000);
        }
        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        private void TenantsForm_Load(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            Toggle.TextBoxEn(tbxID);
            loadData();
        }
        void loadData()
        {

            dynamic data = (from tenant in db.Tenants select new {tenant.TenantID,tenant.FirstName,tenant.LastName,tenant.ContactNumber,tenant.Email,tenant.Password}).ToList();
            DGVTenants.DataSource = data;
        }

        bool inputValidate()
        {

            if (Validations.IsNull(tbxFirstName.Text) || Validations.IsNull(tbxLastName.Text) || Validations.IsNull(tbxPassword.Text)
                || Validations.IsNull(tbxPhone.Text) || Validations.IsNull(tbxEmail.Text))
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {

                    if (!Validations.ValidateEmail(tbxEmail.Text))
                    {
                        MessageBox.Show($"This Field is Email... {tbxEmail.Text}");
                        return;
                    }

                    if (!Validations.IsNumeric(tbxPhone.Text))
                    {
                        MessageBox.Show($"This is Phone field it will be  number.. {tbxPhone.Text}");

                        return;
                    }

                    if (tbxPassword.Text.Length < 4)
                    {
                        MessageBox.Show($"Mininmum Password is 4 ");
                        return;
                    }

                    string hashedPassword;

                    if (tbxPassword.Text.Length > 12)
                    {
                        hashedPassword = tbxPassword.Text;
                    }
                    else
                    {
                        hashedPassword = PasswordManager.hashPassword(tbxPassword.Text);
                    }

                    if (hashedPassword == null)
                    {
                        MessageBox.Show("internal error try agin please....");
                        return;
                    }

                    var result = db.UpdateTenant(int.Parse(tbxID.Text),tbxFirstName.Text, tbxLastName.Text, tbxPhone.Text, tbxEmail.Text, hashedPassword);
                    string response = result.FirstOrDefault();
                    if (response != null)
                    {
                        MessageBox.Show(response);
                    }

                }
                else
                {
                    MessageBox.Show("Fields are Required....");
                    tbxPassword.Text = randomPassword().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadData();
                //clearTexbox();
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {

                    if (!Validations.ValidateEmail(tbxEmail.Text))
                    {
                        MessageBox.Show($"This Field is Email... {tbxEmail.Text}");
                        return;
                    }

                    if (!Validations.IsNumeric(tbxPhone.Text))
                    {
                        MessageBox.Show($"This is Phone field it will be  number.. {tbxPhone.Text}");

                        return;
                    }

                    if (tbxPassword.Text.Length < 4 && tbxPassword.Text.Length > 12)
                    {
                        MessageBox.Show($"Mininmum Password is 4 and Mixinmum Password is 12");
                        return;
                    }

                    string hashedPassword = PasswordManager.hashPassword(tbxPassword.Text);
                    if (hashedPassword == null)
                    {
                        MessageBox.Show("internal error try agin please....");
                        return;
                    }

                    var result = db.CreateTenant(tbxFirstName.Text, tbxLastName.Text, tbxPhone.Text, tbxEmail.Text,hashedPassword);
                    string response = result.FirstOrDefault();
                    if (response != null)
                    {
                        MessageBox.Show(response);
                    }

                }
                else
                {
                    MessageBox.Show("Fields are Required....");
                    tbxPassword.Text = randomPassword().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadData();
                //clearTexbox();
            }
        }

        private void DGVTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxID.Text = DGVTenants.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxFirstName.Text = DGVTenants.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxLastName.Text = DGVTenants.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxEmail.Text = DGVTenants.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbxPhone.Text = DGVTenants.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxPassword.Text = DGVTenants.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var query = db.DeleteTenant(int.Parse(tbxID.Text));
                if (query != null)
                {
                    MessageBox.Show(query.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadData();
            }
        }
    }
}
