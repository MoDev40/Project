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
    public partial class ApartmentForm : Form
    {
        public ApartmentForm()
        {
            InitializeComponent();
        }
        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        void loadData()
        {
            try
            {
                var data = (from apart in db.Apartments select new { apart.ApartmentId, apart.ApartmentName, apart.Location, apart.OwnerContact, apart.OwnerEmail }).ToList();
                DGVApartment.DataSource = data;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApartmentForm_Load(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            loadData();
            tbxID.Enabled = false;
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAvialable_Click(object sender, EventArgs e)
        {
            Toggle.PanelVisible(TopPanel);
        }
        private void btnRented_Click(object sender, EventArgs e)
        {
            Toggle.PanelVisible(TopPanel);
        }

        private void Floors_Click(object sender, EventArgs e)
        {
            ApartFloors apartFloors = new ApartFloors();
            apartFloors.Show();
        }
        bool inputValidate()
        {
            if (Validations.IsNull(tbxApartName.Text) || Validations.IsNull(tbxLocation.Text)
                || Validations.IsNull(tbxPhone.Text) || Validations.IsNull(tbxEmail.Text))
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
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
                        MessageBox.Show($"This is Phone field it will be  number.. ${tbxPhone.Text}");

                        return;
                    }



                    var result = db.CreateApartment(tbxApartName.Text, tbxLocation.Text, tbxPhone.Text,tbxEmail.Text);
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
                //clearTexbox();
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
                        MessageBox.Show($"This is Phone field it will be  number.. ${tbxPhone.Text}");

                        return;
                    }



                    var result = db.UpdateApartment(int.Parse(tbxID.Text),tbxApartName.Text, tbxLocation.Text, tbxPhone.Text, tbxEmail.Text);
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
                //clearTexbox();
            }
        }

        private void DGVApartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = DGVApartment.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxApartName.Text = DGVApartment.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxLocation.Text = DGVApartment.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxPhone.Text = DGVApartment.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxEmail.Text = DGVApartment.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
