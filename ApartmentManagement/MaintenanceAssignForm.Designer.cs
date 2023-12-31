namespace ApartmentManagement
{
    partial class MaintenanceAssignForm
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
            this.DGVMASS = new System.Windows.Forms.DataGridView();
            this.comStatus = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.comStaffID = new System.Windows.Forms.ComboBox();
            this.comReqID = new System.Windows.Forms.ComboBox();
            this.AssDate = new System.Windows.Forms.DateTimePicker();
            this.Delete = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.ViewReq = new System.Windows.Forms.Button();
            this.NewLeas = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.tbxAssID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMASS)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMASS
            // 
            this.DGVMASS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMASS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMASS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMASS.Location = new System.Drawing.Point(0, 155);
            this.DGVMASS.Name = "DGVMASS";
            this.DGVMASS.Size = new System.Drawing.Size(720, 302);
            this.DGVMASS.TabIndex = 1;
            this.DGVMASS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMASS_CellClick);
            // 
            // comStatus
            // 
            this.comStatus.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStatus.FormattingEnabled = true;
            this.comStatus.Items.AddRange(new object[] {
            "Pending",
            "inProgress",
            "Complete"});
            this.comStatus.Location = new System.Drawing.Point(111, 64);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(156, 31);
            this.comStatus.TabIndex = 5;
            this.comStatus.SelectedIndexChanged += new System.EventHandler(this.comStatus_SelectedIndexChanged);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(608, 44);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(109, 27);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(608, 10);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(109, 28);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "AssignedDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "AssignedStaffID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "requestID";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.tbxAssID);
            this.TopPanel.Controls.Add(this.comStaffID);
            this.TopPanel.Controls.Add(this.comReqID);
            this.TopPanel.Controls.Add(this.comStatus);
            this.TopPanel.Controls.Add(this.AssDate);
            this.TopPanel.Controls.Add(this.Delete);
            this.TopPanel.Controls.Add(this.Update);
            this.TopPanel.Controls.Add(this.Insert);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(720, 155);
            this.TopPanel.TabIndex = 0;
            // 
            // comStaffID
            // 
            this.comStaffID.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStaffID.FormattingEnabled = true;
            this.comStaffID.Location = new System.Drawing.Point(434, 67);
            this.comStaffID.Name = "comStaffID";
            this.comStaffID.Size = new System.Drawing.Size(156, 31);
            this.comStaffID.TabIndex = 5;
            // 
            // comReqID
            // 
            this.comReqID.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comReqID.FormattingEnabled = true;
            this.comReqID.Location = new System.Drawing.Point(111, 10);
            this.comReqID.Name = "comReqID";
            this.comReqID.Size = new System.Drawing.Size(156, 31);
            this.comReqID.TabIndex = 5;
            // 
            // AssDate
            // 
            this.AssDate.CustomFormat = "dd-MM-yyyy";
            this.AssDate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AssDate.Location = new System.Drawing.Point(434, 14);
            this.AssDate.Name = "AssDate";
            this.AssDate.Size = new System.Drawing.Size(156, 27);
            this.AssDate.TabIndex = 4;
            this.AssDate.Value = new System.DateTime(2023, 12, 15, 22, 6, 52, 0);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(608, 81);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 30);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DGVMASS);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(144, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(720, 457);
            this.BottomPanel.TabIndex = 10;
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
            // ViewReq
            // 
            this.ViewReq.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewReq.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.ViewReq.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.ViewReq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ViewReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ViewReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewReq.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReq.Location = new System.Drawing.Point(0, 155);
            this.ViewReq.Name = "ViewReq";
            this.ViewReq.Size = new System.Drawing.Size(144, 44);
            this.ViewReq.TabIndex = 0;
            this.ViewReq.Text = "View";
            this.ViewReq.UseVisualStyleBackColor = true;
            // 
            // NewLeas
            // 
            this.NewLeas.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewLeas.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.NewLeas.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.NewLeas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewLeas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.NewLeas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewLeas.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLeas.Location = new System.Drawing.Point(0, 111);
            this.NewLeas.Name = "NewLeas";
            this.NewLeas.Size = new System.Drawing.Size(144, 44);
            this.NewLeas.TabIndex = 0;
            this.NewLeas.Text = "Requests";
            this.NewLeas.UseVisualStyleBackColor = true;
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
            this.LeftPanel.Controls.Add(this.ViewReq);
            this.LeftPanel.Controls.Add(this.NewLeas);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 457);
            this.LeftPanel.TabIndex = 9;
            // 
            // tbxAssID
            // 
            this.tbxAssID.Location = new System.Drawing.Point(111, 111);
            this.tbxAssID.Name = "tbxAssID";
            this.tbxAssID.Size = new System.Drawing.Size(156, 36);
            this.tbxAssID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "AssignID";
            // 
            // MaintenanceAssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 457);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "MaintenanceAssignForm";
            this.Text = "MaintenanceAssignForm";
            this.Load += new System.EventHandler(this.MaintenanceAssignForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMASS)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMASS;
        private System.Windows.Forms.ComboBox comStatus;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DateTimePicker AssDate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button ViewReq;
        private System.Windows.Forms.Button NewLeas;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ComboBox comStaffID;
        private System.Windows.Forms.ComboBox comReqID;
        private System.Windows.Forms.TextBox tbxAssID;
        private System.Windows.Forms.Label label3;
    }
}