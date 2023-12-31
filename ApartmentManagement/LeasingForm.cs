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
    public partial class LeasingForm : Form
    {
        public LeasingForm()
        {
            InitializeComponent();
        }

        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        void fieldVis()
        {
            Toggle.TexttBoxVis(tbxInCorFl);
            Toggle.TexttBoxVis(tbxInCorAp);
            lblInAp.Visible = !lblInAp.Visible;
            lblInFl.Visible = !lblInFl.Visible;
        }

        void loadLeasing()
        {

            var data = (from lease in db.LeasingAgreements select new { lease.LeaseId, lease.TenantID,lease.ApartmentId,lease.FloorID,lease.MoveInDate,lease.LeaseStartDate,lease.LeaseEndDate,lease.AgreementStatus}).ToList();
            DGVLease.DataSource = data;
        }

        int getDayofDate()
        {
            DateTime firstDayOfMonth = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day);

            return firstDayOfMonth.Day;
        }

        void lastDayMovein(int day)
        {
            try
            {

                moveDate.Value = startDate.Value;
                moveDate.MinDate = startDate.Value;
                DateTime todayDayOfMonth = new DateTime(startDate.Value.Year, startDate.Value.Month, day);
                moveDate.MaxDate = todayDayOfMonth.AddDays(15);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void defaultDate()
        {
            DateTime dateTime = DateTime.Today;
            moveDate.Value = dateTime;
            startDate.Value = dateTime;
        }
        private void LeasingForm_Load(object sender, EventArgs e)
        {
            defaultDate();
            Toggle.TextBoxEn(tbxID);
            fieldVis();
            loadLeasing();
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            getAllApart();
        }
        void getAllApart()
        {
            var apartData = (from aprt in db.Apartments select new { aprt.ApartmentName }).ToList();
            comApartment.Items.Clear();
            foreach (var apart in apartData)
            {
                comApartment.Items.Add(apart.ApartmentName);
            }
        }
        int getApartID(string name)
        {
            var getApartID = (from aprt in db.Apartments where aprt.ApartmentName == name select new { aprt.ApartmentId }).ToList();
            return getApartID[0].ApartmentId;
        }

        string getApartname(int id)
        {
            var getApart = (from aprt in db.Apartments where aprt.ApartmentId == id select new { aprt.ApartmentName }).ToList();
            return getApart[0].ApartmentName;
        }

        bool inputValidate()
        {
            if (Validations.IsNull(tenantID.Text) || Validations.IsNull(comApartment.Text) || Validations.IsNull(endDtae.Text)
               || Validations.IsNull(startDate.Text) || Validations.IsNull(comFloor.Text))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        int getFloorID(int floorNum,int apartID)
        {
            var data = (from floor in db.Floors where floor.FloorNumber == floorNum && floor.ApartmentID == apartID select new {floor.FloorID}).ToList();
            return data[0].FloorID;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            bool isComplete = false;
            try
            {
                DateTime date = DateTime.Today;
                if (!inputValidate())
                {
                    if (!Validations.IsInteger(tenantID.Text))
                    {
                        MessageBox.Show($"This field it will be  number.. {tenantID.Text}");

                        return;
                    }

                    if(!(startDate.Value < date))
                    {
                        if(endDtae.Value < startDate.Value.AddMonths(3))
                        {
                            MessageBox.Show("Start date and End date must between 3 month");
                            return;
                        }

                        if(moveDate.Value > startDate.Value.AddDays(15))
                        {
                            MessageBox.Show("After start date 15 days of move in date");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Start date is not les than today");
                        return;
                    }

                    int apartID = getApartID(comApartment.Text);
                    int floorID = getFloorID(int.Parse(comFloor.Text), apartID);
                    var data = db.CreateLeasingAgreement(apartID,int.Parse(tenantID.Text),floorID,moveDate.Value,startDate.Value.Date,endDtae.Value.Date);

                    string res = data.FirstOrDefault();

                    if(res.FirstOrDefault().ToString().Contains("Succesfully"))
                    {
                        isComplete = true;
                    }
                    else
                    {
                        MessageBox.Show(res);
                    }


                }
                else
                {
                    MessageBox.Show("Fields are required....");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadLeasing();
                if (isComplete)
                {
                    clearTexbox();
                }
            }
        }
        

        void getFloors()
        {
            int id = getApartID(comApartment.Text);

            var apartData = (from floor in db.Floors where floor.ApartmentID == id && floor.Status.Contains("Available") select new { floor.FloorNumber }).ToList();
            comFloor.Items.Clear();
            comFloor.Text = "";
            foreach (var floor in apartData)
            {
                comFloor.Items.Add(floor.FloorNumber);
            }
        }
        private void comApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFloors();
        }

        void clearTexbox()
        {
            comApartment.Text = "";
            comFloor.Text = "";
            comFloor.Items.Clear();
            comStatus.Text = "";
            tbxID.Clear();
            tbxInCorAp.Clear();
            tbxInCorFl.Clear();
            tenantID.Clear();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {
                    if (!Validations.IsInteger(tenantID.Text))
                    {
                        MessageBox.Show($"This field it will be  number.. {tenantID.Text}");

                        return;
                    }

                    if (endDtae.Value < startDate.Value.AddMonths(3))
                    {
                        MessageBox.Show("Start date and End date must between 3 month");
                        return;
                    }

                    if (moveDate.Value > startDate.Value.AddDays(15))
                    {
                        MessageBox.Show("After start date 15 days of move in date");
                        return;
                    }

                    int apartID = getApartID(comApartment.Text);
                    int floorID = getFloorID(int.Parse(comFloor.Text), apartID);

                    var res = db.UpdateLeasingAgreement(int.Parse(tbxID.Text), apartID, int.Parse(tenantID.Text), floorID, moveDate.Value, startDate.Value, endDtae.Value, comStatus.Text,int.Parse(tbxInCorFl.Text),int.Parse(tbxInCorAp.Text));
                    MessageBox.Show(res.FirstOrDefault());

                }
                else
                {
                    MessageBox.Show("Fields are required....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadLeasing();
                clearTexbox();
            }
        }

        int getFloorNum(int apartID,int floorID)
        {
            var data = (from floor in db.Floors where floor.FloorID == floorID && floor.ApartmentID == apartID select new { floor.FloorNumber }).ToList();
            return data[0].FloorNumber;
        }
        private void DGVLease_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxID.Text = DGVLease.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenantID.Text = DGVLease.Rows[e.RowIndex].Cells[1].Value.ToString();
            comApartment.Text = getApartname((int)DGVLease.Rows[e.RowIndex].Cells[2].Value);
            comFloor.Text = getFloorNum((int)DGVLease.Rows[e.RowIndex].Cells[2].Value, (int)DGVLease.Rows[e.RowIndex].Cells[3].Value).ToString();
            startDate.Value = (DateTime) DGVLease.Rows[e.RowIndex].Cells[5].Value;
            moveDate.Value = (DateTime) DGVLease.Rows[e.RowIndex].Cells[4].Value;
            endDtae.Value = (DateTime) DGVLease.Rows[e.RowIndex].Cells[6].Value;
            comStatus.Text = DGVLease.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbxInCorAp.Text = DGVLease.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxInCorFl.Text = DGVLease.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {

                    int apartID = getApartID(comApartment.Text);
                    int floorID = getFloorID(int.Parse(comFloor.Text), apartID);

                    var data = db.deleteLeasing(int.Parse(tbxID.Text), apartID,floorID);
                    MessageBox.Show(data.FirstOrDefault());

                }
                else
                {
                    MessageBox.Show("Fields are required....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
                loadLeasing();
                clearTexbox();
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(startDate.Value.AddDays(15).ToString());
        }

        private void endDtae_ValueChanged(object sender, EventArgs e)
        {
        }

        private void ActiveLease_Click(object sender, EventArgs e)
        {

            Toggle.PanelVisible(TopPanel);
            if (!TopPanel.Visible)
            {
                var data = db.getActiveLease();
                DGVLease.DataSource = data;
            }
            else
            {
                loadLeasing();
            }
        }

        private void ExpiredLease_Click(object sender, EventArgs e)
        {
            Toggle.PanelVisible(TopPanel);
            if (!TopPanel.Visible)
            {
                var data = db.getExpiredLease();
                DGVLease.DataSource = data;
            }
            else
            {
                loadLeasing();
            }
        }
        private void incorrectUpdate_Click(object sender, EventArgs e)
        {
            Toggle.PanelVisible(TopPanel);
            if (!TopPanel.Visible)
            {
                var data = db.getTerminatedLease();
                DGVLease.DataSource = data;
            }
            else
            {
                loadLeasing();
            }
        }

        private void NewLeas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
