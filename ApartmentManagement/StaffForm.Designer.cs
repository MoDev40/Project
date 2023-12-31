namespace ApartmentManagement
{
    partial class StaffForm
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DGVStaffs = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.comPosition = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertStaff = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.NewStaff = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaffs)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DGVStaffs);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(144, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(656, 450);
            this.BottomPanel.TabIndex = 6;
            // 
            // DGVStaffs
            // 
            this.DGVStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStaffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVStaffs.Location = new System.Drawing.Point(0, 210);
            this.DGVStaffs.Name = "DGVStaffs";
            this.DGVStaffs.Size = new System.Drawing.Size(656, 240);
            this.DGVStaffs.TabIndex = 1;
            this.DGVStaffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStaffs_CellClick);
            this.DGVStaffs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStaffs_CellContentClick);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.comPosition);
            this.TopPanel.Controls.Add(this.btnDelete);
            this.TopPanel.Controls.Add(this.tbxEmail);
            this.TopPanel.Controls.Add(this.tbxFirstName);
            this.TopPanel.Controls.Add(this.label7);
            this.TopPanel.Controls.Add(this.label);
            this.TopPanel.Controls.Add(this.btnUpdate);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.btnInsertStaff);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.tbxID);
            this.TopPanel.Controls.Add(this.tbxLastName);
            this.TopPanel.Controls.Add(this.tbxPhone);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(656, 210);
            this.TopPanel.TabIndex = 0;
            // 
            // comPosition
            // 
            this.comPosition.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPosition.FormattingEnabled = true;
            this.comPosition.Items.AddRange(new object[] {
            "Apartment Manager",
            "Maintenance Staff",
            "Accounting",
            "Leasing Agent"});
            this.comPosition.Location = new System.Drawing.Point(403, 101);
            this.comPosition.Name = "comPosition";
            this.comPosition.Size = new System.Drawing.Size(170, 34);
            this.comPosition.TabIndex = 4;
            this.comPosition.SelectedIndexChanged += new System.EventHandler(this.comPosition_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(403, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(116, 104);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(170, 31);
            this.tbxEmail.TabIndex = 0;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(116, 50);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(170, 31);
            this.tbxFirstName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Position";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 28);
            this.label.TabIndex = 1;
            this.label.Text = "Email";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(266, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 27);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // btnInsertStaff
            // 
            this.btnInsertStaff.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStaff.Location = new System.Drawing.Point(116, 172);
            this.btnInsertStaff.Name = "btnInsertStaff";
            this.btnInsertStaff.Size = new System.Drawing.Size(124, 27);
            this.btnInsertStaff.TabIndex = 3;
            this.btnInsertStaff.Text = "Insert";
            this.btnInsertStaff.UseVisualStyleBackColor = true;
            this.btnInsertStaff.Click += new System.EventHandler(this.btnInsertStaff_Click);
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
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(116, 10);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(170, 31);
            this.tbxID.TabIndex = 0;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(403, 51);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(170, 31);
            this.tbxLastName.TabIndex = 0;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(403, 10);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(170, 31);
            this.tbxPhone.TabIndex = 0;
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
            // View
            // 
            this.View.Dock = System.Windows.Forms.DockStyle.Top;
            this.View.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(0, 155);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(144, 44);
            this.View.TabIndex = 0;
            this.View.Text = "Staff Records";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // NewStaff
            // 
            this.NewStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewStaff.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.NewStaff.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.NewStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.NewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewStaff.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStaff.Location = new System.Drawing.Point(0, 111);
            this.NewStaff.Name = "NewStaff";
            this.NewStaff.Size = new System.Drawing.Size(144, 44);
            this.NewStaff.TabIndex = 0;
            this.NewStaff.Text = "Staff Register";
            this.NewStaff.UseVisualStyleBackColor = true;
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
            this.LeftPanel.Controls.Add(this.View);
            this.LeftPanel.Controls.Add(this.NewStaff);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 450);
            this.LeftPanel.TabIndex = 5;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaffs)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView DGVStaffs;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button NewStaff;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ComboBox comPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label;
    }
}