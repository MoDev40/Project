namespace ApartmentManagement
{
    partial class UsersForm
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.ViewUsersBtn = new System.Windows.Forms.Button();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStaffId = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.button3);
            this.LeftPanel.Controls.Add(this.ReportBtn);
            this.LeftPanel.Controls.Add(this.ViewUsersBtn);
            this.LeftPanel.Controls.Add(this.NewUserBtn);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 450);
            this.LeftPanel.TabIndex = 1;
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
            this.button3.Text = "Staff Records";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ReportBtn
            // 
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.ReportBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.ReportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.Location = new System.Drawing.Point(0, 199);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(144, 44);
            this.ReportBtn.TabIndex = 0;
            this.ReportBtn.Text = "Reports";
            this.ReportBtn.UseVisualStyleBackColor = true;
            // 
            // ViewUsersBtn
            // 
            this.ViewUsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewUsersBtn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.ViewUsersBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.ViewUsersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ViewUsersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ViewUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewUsersBtn.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUsersBtn.Location = new System.Drawing.Point(0, 155);
            this.ViewUsersBtn.Name = "ViewUsersBtn";
            this.ViewUsersBtn.Size = new System.Drawing.Size(144, 44);
            this.ViewUsersBtn.TabIndex = 0;
            this.ViewUsersBtn.Text = "User Records";
            this.ViewUsersBtn.UseVisualStyleBackColor = true;
            this.ViewUsersBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.NewUserBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.NewUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.NewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUserBtn.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserBtn.Location = new System.Drawing.Point(0, 111);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(144, 44);
            this.NewUserBtn.TabIndex = 0;
            this.NewUserBtn.Text = "User Register";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(144, 111);
            this.LogoPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DGVUsers);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(144, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(656, 450);
            this.BottomPanel.TabIndex = 2;
            // 
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsers.Location = new System.Drawing.Point(0, 155);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.Size = new System.Drawing.Size(656, 295);
            this.DGVUsers.TabIndex = 1;
            this.DGVUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellClick);
            this.DGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.btnDelete);
            this.TopPanel.Controls.Add(this.tbxPassword);
            this.TopPanel.Controls.Add(this.btnUpdate);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.btnInsert);
            this.TopPanel.Controls.Add(this.comboRole);
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.tbxStaffId);
            this.TopPanel.Controls.Add(this.tbxID);
            this.TopPanel.Controls.Add(this.tbxUserName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(656, 155);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(380, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(298, 65);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(170, 31);
            this.tbxPassword.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(230, 117);
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
            this.label3.Location = new System.Drawing.Point(204, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(68, 117);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 28);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // comboRole
            // 
            this.comboRole.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(70, 65);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(121, 36);
            this.comboRole.TabIndex = 2;
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.comboRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "StaffID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tbxStaffId
            // 
            this.tbxStaffId.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaffId.Location = new System.Drawing.Point(543, 10);
            this.tbxStaffId.Name = "tbxStaffId";
            this.tbxStaffId.Size = new System.Drawing.Size(108, 31);
            this.tbxStaffId.TabIndex = 0;
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(70, 13);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(113, 31);
            this.tbxID.TabIndex = 0;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(294, 12);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(170, 31);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "UsersForm";
            this.Text = "UserModifyDash";
            this.Load += new System.EventHandler(this.UserModifyDash_Load);
            this.LeftPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button ViewUsersBtn;
        private System.Windows.Forms.Button NewUserBtn;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStaffId;
        private System.Windows.Forms.DataGridView DGVUsers;
    }
}