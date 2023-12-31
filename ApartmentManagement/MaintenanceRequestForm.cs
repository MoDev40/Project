using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ApartmentManagement
{
    public partial class MaintenanceRequestForm : Form
    {
        public MaintenanceRequestForm()
        {
            InitializeComponent();
        }

        void loadReqs(int tenantID)
        {
            if (tenantID > 0)
            {
                var data = (from req in db.MaintenanceRequests
                            where req.TenantID == tenantID
                            select new
                            { req.RequestID, req.ApartmentID, req.FloorNum, req.TenantID, req.Description, req.RequestDate, req.Status }
                ).ToList();
                DGVRequests.DataSource = data;
            }
            else
            {
                var data = (from req in db.MaintenanceRequests
                            select new
                            { req.RequestID, req.ApartmentID, req.FloorNum, req.TenantID, req.Description, req.RequestDate, req.Status }
                            ).ToList();
                DGVRequests.DataSource = data;
            }
        }
        private void MaintenanceRequestForm_Load(object sender, EventArgs e)
        {
            Toggle.TextBoxEn(tbxID);
            if (LogedTenant.TenantID > 0)
            {
                Toggle.TextBoxEn(tenantID);
                tenantID.Text = LogedTenant.TenantID.ToString();
                Delete.Visible = false;
            }
            else
            {
                lblTen.Visible = false;
                tenantID.Visible = false;
                tenantID.Clear();
            }
            loadReqs(LogedTenant.TenantID);
            getApartmentWithFloor(LogedTenant.TenantID);
        }
        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string getApartname(int id)
        {
            var getApart = (from aprt in db.Apartments where aprt.ApartmentId == id select new { aprt.ApartmentName }).ToList();
            return getApart[0].ApartmentName;
        }
        void getApartmentWithFloor(int tenantID)
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
            else
            {
                var data = (from lease in db.LeasingAgreements select new { lease.ApartmentId }).ToList();
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
        private void tenantID_TextChanged(object sender, EventArgs e)
        {
        }

        bool validateInputs()
        {
            if (Validations.IsNull(comApart.Text) || Validations.IsNull(comFloor.Text)|| Validations.IsNull(ReqDesc.Text) || Validations.IsNull(requestDate.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateInputs())
                {
                    if (LogedTenant.TenantID > 0)
                    {
                        var res = db.CreateMaintenanceReq(getApartID(comApart.Text), int.Parse(comFloor.Text), requestDate.Value, ReqDesc.Text, LogedTenant.TenantID);
                        if (res != null)
                        {
                            MessageBox.Show(res.FirstOrDefault());
                        }
                    }
                    else
                    {
                        var res = db.CreateMaintenanceReq(getApartID(comApart.Text), int.Parse(comFloor.Text), requestDate.Value, ReqDesc.Text, null);
                        if (res != null)
                        {
                            MessageBox.Show(res.FirstOrDefault());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fields are rquired.....");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadReqs(LogedTenant.TenantID);
            }
        }

        int getApartID(string name)
        {
            var getApartID = (from aprt in db.Apartments where aprt.ApartmentName == name select new { aprt.ApartmentId }).ToList();
            return getApartID[0].ApartmentId;
        }
        void getFloors(int tenantID)
        {
            int id = getApartID(comApart.Text);
            if(LogedTenant.TenantID > 0)
            {
                var apartData = (from lease in db.LeasingAgreements where lease.TenantID == tenantID && lease.ApartmentId == id select new {lease.FloorID}).ToList();
                comFloor.Items.Clear();
                comFloor.Text = "";
                foreach (var floor in apartData)
                {
                    comFloor.Items.Add(floor.FloorID);
                }
            }
            else
            {
                var apartData = (from floors in db.Floors where floors.ApartmentID == id select new { floors.FloorID }).ToList();
                comFloor.Items.Clear();
                comFloor.Text = "";
                foreach (var floor in apartData)
                {
                    comFloor.Items.Add(floor.FloorID);
                }
            }
        }
        private void comApart_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFloors(LogedTenant.TenantID);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateInputs())
                {
                    if (LogedTenant.TenantID > 0)
                    {
                        var res = db.UpdateMaintenanceReq(int.Parse(tbxID.Text), getApartID(comApart.Text), int.Parse(comFloor.Text),LogedTenant.TenantID, requestDate.Value, ReqDesc.Text, comStatus.Text);
                        if (res != null)
                        {
                            MessageBox.Show(res.FirstOrDefault());
                        }
                    }
                    else
                    {
                        var res = db.UpdateMaintenanceReq(int.Parse(tbxID.Text),getApartID(comApart.Text), int.Parse(comFloor.Text), null,requestDate.Value, ReqDesc.Text,comStatus.Text);
                        if (res != null)
                        {
                            MessageBox.Show(res.FirstOrDefault());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fields are rquired.....");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadReqs(LogedTenant.TenantID);
            }
        }

        private void DGVRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = DGVRequests.Rows[e.RowIndex].Cells[0].Value.ToString();
            comApart.Text = getApartname((int)DGVRequests.Rows[e.RowIndex].Cells[1].Value);
            comFloor.Text = DGVRequests.Rows[e.RowIndex].Cells[2].Value.ToString();
            comStatus.Text = DGVRequests.Rows[e.RowIndex].Cells[6].Value.ToString();
            ReqDesc.Text = DGVRequests.Rows[e.RowIndex].Cells[4].Value.ToString();
            requestDate.Value = (DateTime) DGVRequests.Rows[e.RowIndex].Cells[5].Value;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateInputs())
                {
                    var res = db.DeleteMaintenanceReq(int.Parse(tbxID.Text));
                    if(res == 1)
                    {
                        MessageBox.Show("Deleted successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Fields are rquired.....");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadReqs(LogedTenant.TenantID);
            }
        }
    }
}
