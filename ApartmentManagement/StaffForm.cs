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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        private dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        void loadPositions() 
        {
            try
            {
                comPosition.Items.Clear();
                var data = (from position in db.Positions select new { position.Position1 });
                foreach(var pos in data)
                {
                    comPosition.Items.Add(pos.Position1);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StaffForm_Load(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            Toggle.TextBoxEn(tbxID);
            loadData();
            loadPositions();
        }

        private void DGVStaffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        bool inputValidate()
        {
            if (Validations.IsNull(tbxFirstName.Text) || Validations.IsNull(tbxLastName.Text) || Validations.IsNull(comPosition.Text)
                || Validations.IsNull(tbxPhone.Text) || Validations.IsNull(tbxEmail.Text))
            {
             
                return true;
            }
            else
            {
                return false;
            }

        }

        void clearTexbox()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxEmail.Clear();
            tbxID.Clear();
            tbxPhone.Clear();
            comPosition.Text = "";

        }

        int getPositionID(string position)
        {
            var positionID = db.getPositionID(position);
            return positionID.FirstOrDefault().Value;
        }
        void loadData()
        {

            dynamic data = (from staff in db.Staffs join pos in db.Positions on staff.PositionID equals pos.PositionID select new { staff.StaffID, staff.FirstName, staff.LastName, staff.Email, staff.ContactNumber,pos.Position1,pos.Salary }).ToList();
            DGVStaffs.DataSource = data;
        }
        private void btnInsertStaff_Click(object sender, EventArgs e)
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

                   
                    
                    var result = db.CreateStaff(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPhone.Text, getPositionID(comPosition.Text));
                    string response = result.FirstOrDefault();
                    if (response != null)
                    {
                        MessageBox.Show(response);
                    }

                }
                else
                {
                    MessageBox.Show("Fields are Required....");
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
                clearTexbox();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                    var result = db.UpdateStaff(int.Parse(tbxID.Text),tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPhone.Text, getPositionID(comPosition.Text));
                    string response = result.FirstOrDefault();
                    if (response != null)
                    {
                        MessageBox.Show(response);
                    }

                }
                else
                {
                    MessageBox.Show("Fields are Required....");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadData();
                clearTexbox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleteStaff(int.Parse(tbxID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadData();
                clearTexbox();
            }
        }

        private void DGVStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxID.Text = DGVStaffs.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxFirstName.Text = DGVStaffs.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxLastName.Text = DGVStaffs.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxEmail.Text = DGVStaffs.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxPhone.Text = DGVStaffs.Rows[e.RowIndex].Cells[4].Value.ToString();
                comPosition.Text = DGVStaffs.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void comPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void View_Click(object sender, EventArgs e)
        {

        }
    }
}
