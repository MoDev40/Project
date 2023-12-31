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
    public partial class ApartFloors : Form
    {
        public ApartFloors()
        {
            InitializeComponent();
        }
        void loadFloorData()
        {
            var data = (from floor in db.Floors select new { floor.FloorID, floor.Rooms, floor.FloorNumber, floor.Price,floor.ApartmentID,floor.Status}).ToList();
            DGVFloors.DataSource = data;
            var apartData = (from aprt in db.Apartments select new { aprt.ApartmentName }).ToList();
            comApartID.Items.Clear();
            foreach(var apart in apartData)
            {
                comApartID.Items.Add(apart.ApartmentName);
            }
        }
        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        bool inputValidate()
        {
            if (Validations.IsNull(tbxRooms.Text) || Validations.IsNull(tbxFloorNum.Text)
                || Validations.IsNull(tbxPrice.Text) || Validations.IsNull(comApartID.Text))
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        int getApartID(string name)
        {
            var getApartID = (from aprt in db.Apartments where aprt.ApartmentName == name select new { aprt.ApartmentId }).ToList();
            return getApartID[0].ApartmentId;
        }

        string getApartname(int id)
        {
            var getApart = (from aprt in db.Apartments where aprt.ApartmentId == id  select new { aprt.ApartmentName }).ToList();
            return getApart[0].ApartmentName;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if(!inputValidate())
                {

                    if (!Validations.IsInteger(tbxFloorNum.Text))
                    {
                        MessageBox.Show($"This Field is a number Field {tbxFloorNum.Text}");
                        tbxFloorNum.Focus();
                        return;
                    }

                    if (!Validations.IsDecimal(tbxPrice.Text))
                    {
                        MessageBox.Show($"This Field is a decimal or number Field {tbxPrice.Text}");
                        tbxPrice.Focus();
                        return;
                    }

                    
                    var data = db.createFloor(int.Parse(tbxFloorNum.Text), tbxRooms.Text, decimal.Parse(tbxPrice.Text),getApartID(comApartID.Text));
                    MessageBox.Show(data.FirstOrDefault());
                }
                else
                {
                    MessageBox.Show("Input Fields are Required....");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                db.SaveChanges();
                loadFloorData();
            }
        }



        private void tbxFloorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApartFloors_Load_1(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            loadFloorData();
            tbxFloorID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {

                    if (!Validations.IsInteger(tbxFloorNum.Text))
                    {
                        MessageBox.Show($"This Field is a number Field {tbxFloorNum.Text}");
                        tbxFloorNum.Focus();
                        return;
                    }

                    if (!Validations.IsDecimal(tbxPrice.Text))
                    {
                        MessageBox.Show($"This Field is a decimal or number Field {tbxPrice.Text}");
                        tbxPrice.Focus();
                        return;
                    }


                    var data = db.updateFloor(int.Parse(tbxFloorID.Text),int.Parse(tbxFloorNum.Text), tbxRooms.Text, decimal.Parse(tbxPrice.Text),getApartID(comApartID.Text),comStatus.Text);
                    MessageBox.Show(data.FirstOrDefault());
                }
                else
                {
                    MessageBox.Show("Input Fields are Required....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadFloorData();
            }
        }

        private void DGVFloors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxFloorID.Text = DGVFloors.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxRooms.Text = DGVFloors.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxFloorNum.Text = DGVFloors.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxPrice.Text = DGVFloors.Rows[e.RowIndex].Cells[3].Value.ToString();
                comStatus.Text = DGVFloors.Rows[e.RowIndex].Cells[5].Value.ToString();
                comApartID.Text = getApartname(int.Parse(DGVFloors.Rows[e.RowIndex].Cells[4].Value.ToString()));

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 
                var data = db.deleteFloor(int.Parse(tbxFloorID.Text));
                MessageBox.Show(data.FirstOrDefault());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadFloorData();
            }
        }
    }
}
