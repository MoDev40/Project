namespace ApartmentManagement
{
    partial class TenantsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.DGVTenants = new System.Windows.Forms.DataGridView();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.ViewTenant = new System.Windows.Forms.Button();
            this.NewTenant = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenants)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(428, 173);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(124, 27);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(116, 50);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(170, 31);
            this.tbxFirstName.TabIndex = 0;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(278, 172);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(124, 27);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "First name";
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(116, 172);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(124, 27);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(403, 10);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(170, 31);
            this.tbxPhone.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.Delete);
            this.TopPanel.Controls.Add(this.tbxEmail);
            this.TopPanel.Controls.Add(this.tbxFirstName);
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.Update);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.Insert);
            this.TopPanel.Controls.Add(this.label6);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.tbxID);
            this.TopPanel.Controls.Add(this.tbxPassword);
            this.TopPanel.Controls.Add(this.tbxLastName);
            this.TopPanel.Controls.Add(this.tbxPhone);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(656, 214);
            this.TopPanel.TabIndex = 0;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(116, 98);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(170, 31);
            this.tbxEmail.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(116, 10);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(170, 31);
            this.tbxID.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(403, 102);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(170, 31);
            this.tbxPassword.TabIndex = 0;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(403, 51);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(170, 31);
            this.tbxLastName.TabIndex = 0;
            // 
            // DGVTenants
            // 
            this.DGVTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTenants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTenants.Location = new System.Drawing.Point(0, 214);
            this.DGVTenants.Name = "DGVTenants";
            this.DGVTenants.Size = new System.Drawing.Size(656, 236);
            this.DGVTenants.TabIndex = 1;
            this.DGVTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTenants_CellClick);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DGVTenants);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(144, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(656, 450);
            this.BottomPanel.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reports.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.Reports.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.Reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Location = new System.Drawing.Point(0, 199);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(144, 44);
            this.Reports.TabIndex = 0;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // ViewTenant
            // 
            this.ViewTenant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewTenant.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.ViewTenant.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.ViewTenant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ViewTenant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ViewTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTenant.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTenant.Location = new System.Drawing.Point(0, 155);
            this.ViewTenant.Name = "ViewTenant";
            this.ViewTenant.Size = new System.Drawing.Size(144, 44);
            this.ViewTenant.TabIndex = 0;
            this.ViewTenant.Text = "View";
            this.ViewTenant.UseVisualStyleBackColor = true;
            // 
            // NewTenant
            // 
            this.NewTenant.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewTenant.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.NewTenant.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.NewTenant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewTenant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.NewTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTenant.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTenant.Location = new System.Drawing.Point(0, 111);
            this.NewTenant.Name = "NewTenant";
            this.NewTenant.Size = new System.Drawing.Size(144, 44);
            this.NewTenant.TabIndex = 0;
            this.NewTenant.Text = "New Tenant";
            this.NewTenant.UseVisualStyleBackColor = true;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(144, 111);
            this.LogoPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.button3);
            this.LeftPanel.Controls.Add(this.Reports);
            this.LeftPanel.Controls.Add(this.ViewTenant);
            this.LeftPanel.Controls.Add(this.NewTenant);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 450);
            this.LeftPanel.TabIndex = 3;
            // 
            // TenantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "TenantsForm";
            this.Text = "TenantsForm";
            this.Load += new System.EventHandler(this.TenantsForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenants)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox tbxFirstName;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.DataGridView DGVTenants;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button ViewTenant;
        private System.Windows.Forms.Button NewTenant;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxLastName;
    }
}