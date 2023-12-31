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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        string getApartname(int id)
        {
            var getApart = (from aprt in db.Apartments where aprt.ApartmentId == id select new { aprt.ApartmentName }).ToList();
            return getApart[0].ApartmentName;
        }

        void getApartments(int tenantID)
        {
            if (tenantID > 0)
            {
                var data = (from lease in db.LeasingAgreements where lease.TenantID == tenantID select new { lease.ApartmentId }).ToList();
                comApart.Items.Clear();
                foreach (var lease in data)
                {
                    if (comApart.Items.Contains(getApartname(lease.ApartmentId)))
                    {
                    }
                    else
                    {
                        comApart.Items.Add(getApartname(lease.ApartmentId));
                    }
                }
            }
        }

        void loadPayment()
        {
            var data = (from pay in db.Payments select new {pay.PaymentID,pay.LeaseID,pay.MaintenanceID,pay.PaymentDate,pay.PaymentAmount,pay.PaymentDesc}).ToList();
            DGVPayRec.DataSource = data;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            ReqID.Enabled = false;
            payID.Enabled = false;
            comboFeeTpye.Text = comboFeeTpye.Items[0].ToString();
            tbxAmount.Enabled = false;
            TopPanel.Visible = false;
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            DateTime dateTime = DateTime.Today;
            PaymentDate.Value = dateTime;
            loadPayment();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            Toggle.PanelVisible(PayPanel);
            //Toggle.DataGridVis(DGVPayRec)
            Toggle.PanelVisible(TopPanel);

        }

        private void PaymentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_Click(object sender, EventArgs e)
        {
            Toggle.PanelVisible(PayPanel);
            Toggle.PanelVisible(TopPanel);
            loadPayment();
        }

        private void tenantID_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsNull(tenantID.Text) && Validations.IsInteger(tenantID.Text))
            {
                getApartments(int.Parse(tenantID.Text));
            }
        }

        private void PaymentRecords_Click(object sender, EventArgs e)
        {
            TopPanel.Visible = true;
            PayPanel.Visible = false;
            var data = db.getPaymentInfo();
            DGVPayRec.DataSource = data;
        }

        int getApartID(string name)
        {
            var getApartID = (from aprt in db.Apartments where aprt.ApartmentName == name select new { aprt.ApartmentId }).ToList();
            return getApartID[0].ApartmentId;
        }

        int getFloorNum(int id)
        {
            var res = (from floor in db.Floors where floor.FloorID == id select new { floor.FloorNumber }).ToList();
            return res[0].FloorNumber;
        }
        int getFloorID(int apartID,int floorNum)
        {
            var res = (from floor in db.Floors where floor.FloorNumber == floorNum && floor.ApartmentID == apartID select new { floor.FloorID }).ToList();
            return res[0].FloorID;
        }

        void getFloor(int tenantID)
        {
            int id = getApartID(comApart.Text);
            var apartData = (from lease in db.LeasingAgreements where lease.TenantID == tenantID && lease.ApartmentId == id select new { lease.FloorID }).ToList();
            comFloor.Items.Clear();
            comFloor.Text = "";
            foreach (var floor in apartData)
            {
                comFloor.Items.Add(getFloorNum((int)floor.FloorID));
            }
        }
        int getSelectedFeeTypeIndex()
        {
            return comboFeeTpye.SelectedIndex;
        }
        private void comApart_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFloor(int.Parse(tenantID.Text));
        }

        decimal getFloorPrice(int florID)
        {
            var res = (from floor in db.Floors where floor.FloorID == florID  select new { floor.Price }).ToList();
            return res[0].Price;
        }
        private void comFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxAmount.Clear();
            tbxAmount.Text = getFloorPrice(getFloorID(getApartID(comApart.Text), int.Parse(comFloor.Text))).ToString();
        }

        private void comboFeeTpye_SelectedIndexChanged(object sender, EventArgs e)
        {
            comApart.Text = "";
            comFloor.Text = "";
            tbxAmount.Clear();
            ReqID.Clear();

            if (getSelectedFeeTypeIndex() == 1)
            {
                tbxAmount.Enabled = true;
                tenantID.Enabled = false;
                comApart.Enabled = false;
                comFloor.Enabled = false;
                ReqID.Enabled = true;

            }
            else
            {
                tenantID.Enabled = true;
                tbxAmount.Enabled = false;
                comApart.Enabled = true;
                comFloor.Enabled = true;
            }
        }

        bool inputValidate()
        {
            if(getSelectedFeeTypeIndex() == 0)
            {
                bool res = false;
                if(Validations.IsNull(comApart.Text)|| Validations.IsNull(comFloor.Text) || Validations.IsNull(tenantID.Text)
                    || Validations.IsNull(PaymentDate.Text)||Validations.IsNull(tbxAmount.Text))
                {
                    res = true;
                }
                else
                {
                    res =  false;
                }
                return res;
            }
            else
            {
                return false;
            }
        }
        private void insertPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inputValidate())
                {
                    if (!Validations.IsDecimal(tbxAmount.Text))
                    {
                        MessageBox.Show("This Field is decimal Field.....");
                        tbxAmount.Focus();
                        return;
                    }
                    if(getSelectedFeeTypeIndex() == 0)
                    {
                        var getLeaseID = db.getLeaseID(getApartID(comApart.Text), getFloorID(getApartID(comApart.Text), int.Parse(comFloor.Text))).ToList(); 
                        int leaseID = (int)getLeaseID.FirstOrDefault();
                        var res = db.CreatePayment(leaseID,null, decimal.Parse(tbxAmount.Text), PaymentDate.Value, comboFeeTpye.Text);
                        MessageBox.Show(res.FirstOrDefault());

                    }
                    else if(getSelectedFeeTypeIndex() == 1)
                    {
                        var res = db.CreatePayment(null, int.Parse(ReqID.Text), decimal.Parse(tbxAmount.Text), PaymentDate.Value, comboFeeTpye.Text);
                        MessageBox.Show(res.FirstOrDefault());
                    }
                }
                else
                {
                    MessageBox.Show("Fields are required.....");
            }

        }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                db.SaveChanges();
                loadPayment();
}
        }
    }
}
