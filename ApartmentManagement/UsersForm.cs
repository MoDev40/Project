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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Toggle.PanelVisible(TopPanel);
        }

        void getRoles()
        {
            try
            {

                    dynamic fetchData = (from role in db.Roles select new { role.RoleID, role.RoleName }).ToList();

                    foreach (var item in fetchData)
                    {

                        comboRole.Items.Add(item.RoleName);
                    }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UserModifyDash_Load(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            DGVUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Toggle.TextBoxEn(tbxID);
            loadUsers();
            getRoles();
     
        }
        bool inputValidate()
        {
            if (Validations.IsNull(tbxUserName.Text) || Validations.IsNull(comboRole.Text) || Validations.IsNull(tbxPassword.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void loadUsers()
        {
            try
            {
    
                dynamic data = (from user in db.Users select new {user.UserID,user.UserName,user.RoleID,user.PasswordHash,user.StaffID}).ToList();
                DGVUsers.DataSource = data;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
                try
                {
                    if (!inputValidate())
                    {
                        if (tbxStaffId.Enabled && !Validations.IsInteger(tbxStaffId.Text))
                        {
                            MessageBox.Show($"This field is Number {tbxStaffId.Text}");
                            return;
                        }

                        if (tbxPassword.Text.Length < 4 && tbxPassword.Text.Length > 12)
                        {
                            MessageBox.Show($"Mininmum Password is 4 and Mixinmum Password is 12");
                            return;
                        }
                        if (!Validations.ValidatePassword(tbxPassword.Text))
                        {
                            MessageBox.Show($"Password must capital later small later and number {tbxPassword.Text}");
                            return;

                        }

                        if (Validations.ValidateEmail(tbxUserName.Text))
                        {
                            MessageBox.Show("Remove this user@gmail.com we don't accept this");
                            return;
                        }

                        string hashedPassword = PasswordManager.hashPassword(tbxPassword.Text);
                        if (hashedPassword == null) 
                        {
                            MessageBox.Show("internal error try agin please....");
                            return;
                        }

                        var roles = (from role in db.Roles where role.RoleName == comboRole.Text select new { role.RoleID }).ToList();

                        
                        string response;

                        if(comboRole.Text == "Admin")
                        {
                             var data = db.CreateUser(tbxUserName.Text, hashedPassword,roles[0].RoleID,null);
                             response = data.FirstOrDefault();
                        }
                        else
                        {
                             var data = db.CreateUser(tbxUserName.Text, hashedPassword, roles[0].RoleID, int.Parse(tbxStaffId.Text));
                             response = data.FirstOrDefault();
                           
                        }

                        MessageBox.Show(response);

                    }
                    else
                    {
                        MessageBox.Show("Fields are Required.....");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.SaveChanges();
                    loadUsers();
                }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboRole.Text == "Admin")
            {
                tbxStaffId.Clear();
                tbxStaffId.Enabled = false;
            }
            else
            {
                tbxStaffId.Enabled = true;
            }
        }

        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxID.Text = DGVUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxUserName.Text = DGVUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxPassword.Text = DGVUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                if(DGVUsers.Rows[e.RowIndex].Cells[4].Value == null)
                {
                    tbxStaffId.Clear();
                    comboRole.Text = "Admin";
                }
                else
                {
                    tbxStaffId.Text = DGVUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                    comboRole.Text = "Staff";
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbApartmentManagementEntities db = new dbApartmentManagementEntities();
            try
            {
                db.DeleteUser(int.Parse(tbxID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadUsers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {
                    if (tbxStaffId.Enabled && !Validations.IsInteger(tbxStaffId.Text))
                    {
                        MessageBox.Show($"This field is Number {tbxStaffId.Text}");
                        return;
                    }

                    if (tbxPassword.Text.Length < 4 )
                    {
                        MessageBox.Show($"Mininmum Password is 4 {tbxPassword.Text}");
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

                    int roleID = 0;
                    var roles = (from role in db.Roles where role.RoleName == comboRole.Text select new { role.RoleID }).ToList();

                    roleID = roles[0].RoleID;

                    string response;

                    if (comboRole.Text == "Admin")
                    {
                        var data = db.UpdateUser(int.Parse(tbxID.Text),tbxUserName.Text, hashedPassword, roleID, null);
                        response = data.FirstOrDefault();
                    }
                    else
                    {
                        var data = db.UpdateUser(int.Parse(tbxID.Text), tbxUserName.Text, hashedPassword, roleID, int.Parse(tbxStaffId.Text));
                        response = data.FirstOrDefault();

                    }

                    MessageBox.Show(response);

                }
                else
                {
                    MessageBox.Show("Fields are Required.....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadUsers();
            }
        }

        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {

            if (Validations.ValidateEmail(tbxUserName.Text))
            {
                MessageBox.Show("Remove this user@gmail.com we don't accept this");
            }
        }
    }
}
