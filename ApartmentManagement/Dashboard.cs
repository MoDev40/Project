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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //void iconImages()
        //{
        //    Apartments.Image = Resource1.apartment;
        //    Users.Image = Resource1.Users;
        //    Payments.Image = Resource1.wallet;
        //    btnStaffs.Image = Resource1.staffs;
        //    MaintenceRequest.Image = Resource1.renovation;
        //    LeasingAgreements.Image = Resource1.lease;
        //    Roles.Image = Resource1.info;
        //    Tenants.Image = Resource1.landlord;
        //}

        void homeImage()
        {
            btnApartStatus.Image = Resource1.apartments;
            btnCusStatus.Image = Resource1.landlord;
            btnRatStatus.Image = Resource1.rate;
            btnStaffStatus.Image = Resource1.employee;
            LogoPanel.BackgroundImage = Resource1.Logo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
        }
        dbApartmentManagementEntities db = new dbApartmentManagementEntities();
        void VisibleNavs() {
            Roles.Visible = true;
            btnStaffs.Visible = true;
            Payments.Visible = true;
            Users.Visible = true;
            Apartments.Visible = true;
            Tenants.Visible = true;
            MaintenceRequest.Visible = true;
            MaintenceAssignments.Visible = true;
            LeasingAgreements.Visible = true;
        }
        void disNavs()
        {
            Roles.Visible = false;
            btnStaffs.Visible = false;
            Payments.Visible = false;
            Users.Visible = false;
            Apartments.Visible = false;
            Tenants.Visible = false;
            MaintenceRequest.Visible = false;
            MaintenceAssignments.Visible = false;
            LeasingAgreements.Visible = false;
        }
        void PostitionIdentfier()
        {
            var position = (from pos in db.Positions select new { pos.Position1 }).ToList();

                //Position Manager
                if (LogedUser.Position == position[0].Position1)
                {
                    Roles.Visible = true;
                    btnStaffs.Visible = true;
                    Users.Visible = true;

                }
                //Position Leasing
                else if (LogedUser.Position == position[1].Position1)
                {
                    Roles.Visible = true;
                    btnStaffs.Visible = true;
                    MaintenceRequest.Visible = true;
                    MaintenceAssignments.Visible = true;
                    Payments.Visible = true;
                    Users.Visible = true;

                }

                //Position Finance
                 else if (LogedUser.Position == position[2].Position1)
                {
                    Roles.Visible = true;
                    btnStaffs.Visible = true;
                    MaintenceRequest.Visible = true;
                    MaintenceAssignments.Visible = true;
                    Users.Visible = true;
                }
                //Position Maintenance
                else if (LogedUser.Position == position[3].Position1)
                {
                    Roles.Visible = true;
                    btnStaffs.Visible = true;
                    Payments.Visible = true;
                    Users.Visible = true;
                    MaintenceRequest.Visible = true;
                    Apartments.Visible = true;
                    Tenants.Visible = true;
                }else if (LogedTenant.TenantID > 0)
                {
                    MaintenceRequest.Visible = true;
                    Apartments.Visible = true;
                    Payments.Visible = true;
                    Tenants.Visible = true;

                }else if (LogedUser.IsAdmin)
                {
                    VisibleNavs();
                }
        }

        void checkLog()
        {
            try
            {

                if (LogedUser.IsLogin)
                {
                    btnLogOut.Visible = true;
                    btnLogIn.Visible = false;
                }
                else
                {
                    btnLogOut.Visible = false;
                    btnLogIn.Visible = true;
                }
                PostitionIdentfier();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            homeImage();
            checkLog();
            //disNavs();
        }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
            checkLog();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MaintenanceAssignForm maintenanceAssign = new MaintenanceAssignForm();
            maintenanceAssign.ShowDialog();
        }

        private void Apartments_Click(object sender, EventArgs e)
        {
            ApartmentForm apartment = new ApartmentForm();
            apartment.ShowDialog();
        }

        private void Tenants_Click(object sender, EventArgs e)
        {
            TenantsForm tenantsForm = new TenantsForm();
            tenantsForm.ShowDialog();
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            UsersForm userModify = new UsersForm();
            userModify.ShowDialog();
        }

        private void MaintenceRequest_Click(object sender, EventArgs e)
        {
            MaintenanceRequestForm maintenanceRequest = new MaintenanceRequestForm();
            maintenanceRequest.ShowDialog();
        }

        private void LeasingAgreements_Click(object sender, EventArgs e)
        {
            LeasingForm leasingForm = new LeasingForm();
            leasingForm.ShowDialog();
        }

        private void Staffs_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }

        private void Roles_Click(object sender, EventArgs e)
        {
            RolesForm rolesForm = new RolesForm();
            rolesForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogedUser.IsLogin = false;

            if(LogedTenant.TenantID > 0)
            {
                LogedTenant.TenantID = 0;
                LogedTenant.TenantName = "";
                LogedTenant.Email = "";
            }
            else if(LogedUser.UserID > 0)
            {
                LogedUser.Position = "";
                LogedUser.UserName = "";
                LogedUser.UserID = 0;
                LogedUser.IsAdmin = false;
            }
            checkLog();
            disNavs();
        }
    }
}
