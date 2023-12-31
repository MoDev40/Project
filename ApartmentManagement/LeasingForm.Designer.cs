namespace ApartmentManagement
{
    partial class LeasingForm
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
            this.DGVLease = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.comStatus = new System.Windows.Forms.ComboBox();
            this.comFloor = new System.Windows.Forms.ComboBox();
            this.comApartment = new System.Windows.Forms.ComboBox();
            this.moveDate = new System.Windows.Forms.DateTimePicker();
            this.endDtae = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.delete = new System.Windows.Forms.Button();
            this.tbxInCorFl = new System.Windows.Forms.TextBox();
            this.tbxInCorAp = new System.Windows.Forms.TextBox();
            this.tenantID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInFl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInAp = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.TerminatedLease = new System.Windows.Forms.Button();
            this.ExpiredLease = new System.Windows.Forms.Button();
            this.ActiveLease = new System.Windows.Forms.Button();
            this.NewLeas = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLease)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DGVLease);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(144, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(693, 448);
            this.BottomPanel.TabIndex = 6;
            // 
            // DGVLease
            // 
            this.DGVLease.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLease.Location = new System.Drawing.Point(0, 237);
            this.DGVLease.Name = "DGVLease";
            this.DGVLease.Size = new System.Drawing.Size(693, 211);
            this.DGVLease.TabIndex = 1;
            this.DGVLease.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLease_CellClick);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.comStatus);
            this.TopPanel.Controls.Add(this.comFloor);
            this.TopPanel.Controls.Add(this.comApartment);
            this.TopPanel.Controls.Add(this.moveDate);
            this.TopPanel.Controls.Add(this.endDtae);
            this.TopPanel.Controls.Add(this.startDate);
            this.TopPanel.Controls.Add(this.delete);
            this.TopPanel.Controls.Add(this.tbxInCorFl);
            this.TopPanel.Controls.Add(this.tbxInCorAp);
            this.TopPanel.Controls.Add(this.tenantID);
            this.TopPanel.Controls.Add(this.lbl);
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.lblInFl);
            this.TopPanel.Controls.Add(this.label7);
            this.TopPanel.Controls.Add(this.lblInAp);
            this.TopPanel.Controls.Add(this.Update);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.Insert);
            this.TopPanel.Controls.Add(this.label6);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.tbxID);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(693, 237);
            this.TopPanel.TabIndex = 0;
            // 
            // comStatus
            // 
            this.comStatus.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStatus.FormattingEnabled = true;
            this.comStatus.Items.AddRange(new object[] {
            "Active",
            "Expired",
            "Terminated"});
            this.comStatus.Location = new System.Drawing.Point(401, 101);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(172, 31);
            this.comStatus.TabIndex = 5;
            // 
            // comFloor
            // 
            this.comFloor.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFloor.FormattingEnabled = true;
            this.comFloor.Location = new System.Drawing.Point(401, 53);
            this.comFloor.Name = "comFloor";
            this.comFloor.Size = new System.Drawing.Size(172, 31);
            this.comFloor.TabIndex = 5;
            // 
            // comApartment
            // 
            this.comApartment.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comApartment.FormattingEnabled = true;
            this.comApartment.Location = new System.Drawing.Point(403, 6);
            this.comApartment.Name = "comApartment";
            this.comApartment.Size = new System.Drawing.Size(172, 31);
            this.comApartment.TabIndex = 5;
            this.comApartment.SelectedIndexChanged += new System.EventHandler(this.comApartment_SelectedIndexChanged);
            // 
            // moveDate
            // 
            this.moveDate.CustomFormat = "dd-MM-yyyy";
            this.moveDate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.moveDate.Location = new System.Drawing.Point(401, 148);
            this.moveDate.Name = "moveDate";
            this.moveDate.Size = new System.Drawing.Size(172, 27);
            this.moveDate.TabIndex = 4;
            this.moveDate.Value = new System.DateTime(2023, 12, 15, 22, 6, 52, 0);
            // 
            // endDtae
            // 
            this.endDtae.CustomFormat = "dd-MM-yyyy";
            this.endDtae.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDtae.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDtae.Location = new System.Drawing.Point(103, 148);
            this.endDtae.Name = "endDtae";
            this.endDtae.Size = new System.Drawing.Size(124, 27);
            this.endDtae.TabIndex = 4;
            this.endDtae.Value = new System.DateTime(2023, 12, 15, 22, 6, 52, 0);
            this.endDtae.ValueChanged += new System.EventHandler(this.endDtae_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd-MM-yyyy";
            this.startDate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(103, 100);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(124, 27);
            this.startDate.TabIndex = 4;
            this.startDate.Value = new System.DateTime(2023, 12, 15, 22, 6, 52, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(598, 142);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 36);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tbxInCorFl
            // 
            this.tbxInCorFl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInCorFl.Location = new System.Drawing.Point(425, 198);
            this.tbxInCorFl.Name = "tbxInCorFl";
            this.tbxInCorFl.Size = new System.Drawing.Size(148, 31);
            this.tbxInCorFl.TabIndex = 0;
            // 
            // tbxInCorAp
            // 
            this.tbxInCorAp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInCorAp.Location = new System.Drawing.Point(124, 198);
            this.tbxInCorAp.Name = "tbxInCorAp";
            this.tbxInCorAp.Size = new System.Drawing.Size(149, 31);
            this.tbxInCorAp.TabIndex = 0;
            // 
            // tenantID
            // 
            this.tenantID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantID.Location = new System.Drawing.Point(103, 50);
            this.tenantID.Name = "tenantID";
            this.tenantID.Size = new System.Drawing.Size(170, 31);
            this.tenantID.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(308, 101);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 28);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "startDate";
            // 
            // lblInFl
            // 
            this.lblInFl.AutoSize = true;
            this.lblInFl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInFl.Location = new System.Drawing.Point(283, 202);
            this.lblInFl.Name = "lblInFl";
            this.lblInFl.Size = new System.Drawing.Size(139, 28);
            this.lblInFl.TabIndex = 1;
            this.lblInFl.Text = "InCorrectFloorID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "FloorID";
            // 
            // lblInAp
            // 
            this.lblInAp.AutoSize = true;
            this.lblInAp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInAp.Location = new System.Drawing.Point(10, 201);
            this.lblInAp.Name = "lblInAp";
            this.lblInAp.Size = new System.Drawing.Size(108, 28);
            this.lblInAp.TabIndex = 1;
            this.lblInAp.Text = "InCorrectAp";
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(598, 74);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(87, 37);
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
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "TenantID";
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(596, 9);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(89, 36);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "endDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "MoveInDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ApartmentID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "LeaseID";
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(103, 10);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(170, 31);
            this.tbxID.TabIndex = 0;
            // 
            // TerminatedLease
            // 
            this.TerminatedLease.Dock = System.Windows.Forms.DockStyle.Top;
            this.TerminatedLease.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.TerminatedLease.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.TerminatedLease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.TerminatedLease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.TerminatedLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TerminatedLease.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminatedLease.Location = new System.Drawing.Point(0, 243);
            this.TerminatedLease.Name = "TerminatedLease";
            this.TerminatedLease.Size = new System.Drawing.Size(144, 42);
            this.TerminatedLease.TabIndex = 0;
            this.TerminatedLease.Text = "Terminated Lease";
            this.TerminatedLease.UseVisualStyleBackColor = true;
            this.TerminatedLease.Click += new System.EventHandler(this.incorrectUpdate_Click);
            // 
            // ExpiredLease
            // 
            this.ExpiredLease.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpiredLease.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.ExpiredLease.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.ExpiredLease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExpiredLease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ExpiredLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpiredLease.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredLease.Location = new System.Drawing.Point(0, 199);
            this.ExpiredLease.Name = "ExpiredLease";
            this.ExpiredLease.Size = new System.Drawing.Size(144, 44);
            this.ExpiredLease.TabIndex = 0;
            this.ExpiredLease.Text = "Exprired Lease";
            this.ExpiredLease.UseVisualStyleBackColor = true;
            this.ExpiredLease.Click += new System.EventHandler(this.ExpiredLease_Click);
            // 
            // ActiveLease
            // 
            this.ActiveLease.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveLease.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.ActiveLease.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.ActiveLease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ActiveLease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ActiveLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveLease.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveLease.Location = new System.Drawing.Point(0, 155);
            this.ActiveLease.Name = "ActiveLease";
            this.ActiveLease.Size = new System.Drawing.Size(144, 44);
            this.ActiveLease.TabIndex = 0;
            this.ActiveLease.Text = "Active Lease";
            this.ActiveLease.UseVisualStyleBackColor = true;
            this.ActiveLease.Click += new System.EventHandler(this.ActiveLease_Click);
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
            this.NewLeas.Text = "New Agreement";
            this.NewLeas.UseVisualStyleBackColor = true;
            this.NewLeas.Click += new System.EventHandler(this.NewLeas_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.TerminatedLease);
            this.LeftPanel.Controls.Add(this.ExpiredLease);
            this.LeftPanel.Controls.Add(this.ActiveLease);
            this.LeftPanel.Controls.Add(this.NewLeas);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 448);
            this.LeftPanel.TabIndex = 5;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(144, 111);
            this.LogoPanel.TabIndex = 0;
            // 
            // LeasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 448);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "LeasingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeasingForm";
            this.Load += new System.EventHandler(this.LeasingForm_Load);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLease)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView DGVLease;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox tenantID;
        private System.Windows.Forms.Label label4;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button TerminatedLease;
        private System.Windows.Forms.Button ExpiredLease;
        private System.Windows.Forms.Button ActiveLease;
        private System.Windows.Forms.Button NewLeas;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.DateTimePicker moveDate;
        private System.Windows.Forms.DateTimePicker endDtae;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comFloor;
        private System.Windows.Forms.ComboBox comApartment;
        private System.Windows.Forms.ComboBox comStatus;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbxInCorFl;
        private System.Windows.Forms.TextBox tbxInCorAp;
        private System.Windows.Forms.Label lblInFl;
        private System.Windows.Forms.Label lblInAp;
    }
}