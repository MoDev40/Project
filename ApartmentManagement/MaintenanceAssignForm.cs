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
    public partial class MaintenanceAssignForm : Form
    {
        public MaintenanceAssignForm()
        {
            InitializeComponent();
        }

        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        void loadReq()
        {
            var reqData = (from req in db.MaintenanceRequests where req.Status.Contains("Pending") select new { req.RequestID }).ToList();
            foreach(var reqs in reqData)
            {
                comReqID.Items.Add(reqs.RequestID);
            }
        }

        void loadAssigns()
        {
            var maiAss = (from mAssing in db.MaintenanceAssignments select new { mAssing.AssignmentID,mAssing.RequestID,mAssing.AssignedStaffID,mAssing.AssignmentDate,mAssing.CompletionStatus }).ToList();
            DGVMASS.DataSource = maiAss;
        }
        void loadMaintenanceStaff()
        {
            var staffData = (from staff in db.Staffs join pos in db.Positions on staff.PositionID equals pos.PositionID where pos.Position1.Contains("Maintenance") select new { staff.StaffID }).ToList();
            foreach(var staffs in staffData)
            {
                comStaffID.Items.Add(staffs.StaffID);
            }
        }

        private void MaintenanceAssignForm_Load(object sender, EventArgs e)
        {
            tbxAssID.Enabled = false;
            loadReq();
            loadMaintenanceStaff();
            loadAssigns();
        }
        bool validateInputs()
        {
            if (Validations.IsNull(comReqID.Text) || Validations.IsNull(comStaffID.Text) || Validations.IsNull(AssDate.Text))
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
                var response = db.CreateMaintenanceAssign(int.Parse(comReqID.Text), int.Parse(comStaffID.Text),AssDate.Value);
                MessageBox.Show(response.FirstOrDefault());
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
                loadAssigns();
                loadReq();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateInputs())
                {
                    var response = db.UpdateMaintenanceAssign(int.Parse(tbxAssID.Text),int.Parse(comReqID.Text), int.Parse(comStaffID.Text), AssDate.Value,comStatus.Text);

                    if (comStatus.Text == comStatus.Items[2].ToString())
                    {
                        dbApartmentManagementEntities dbm = new dbApartmentManagementEntities();
                        var res = dbm.updateReqStatus(int.Parse(comReqID.Text), comStatus.Text);
                        dbm.SaveChanges();
                    }else if (comStatus.Text == comStatus.Items[1].ToString())
                    {
                        dbApartmentManagementEntities dbm = new dbApartmentManagementEntities();
                        var res = dbm.updateReqStatus(int.Parse(comReqID.Text), comStatus.Items[1].ToString());
                        dbm.SaveChanges();
                    }else if (comStatus.Text == comStatus.Items[0].ToString())
                    {
                        dbApartmentManagementEntities dbm = new dbApartmentManagementEntities();
                        var res = dbm.updateReqStatus(int.Parse(comReqID.Text), comStatus.Items[0].ToString());
                        dbm.SaveChanges();
                    }

                    MessageBox.Show(response.FirstOrDefault());
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
                loadAssigns();
                loadReq();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateInputs())
                {
                    var response = db.DeleteMaintenanceAssign(int.Parse(tbxAssID.Text));
                    MessageBox.Show(response.ToString());
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
                loadAssigns();
                loadReq();
            }
        }

        private void DGVMASS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAssID.Text = DGVMASS.Rows[e.RowIndex].Cells[0].Value.ToString();
            comReqID.Text = DGVMASS.Rows[e.RowIndex].Cells[1].Value.ToString();
            comStaffID.Text = DGVMASS.Rows[e.RowIndex].Cells[2].Value.ToString();
            AssDate.Value = (DateTime) DGVMASS.Rows[e.RowIndex].Cells[3].Value;
            comStatus.Text = DGVMASS.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void comStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
