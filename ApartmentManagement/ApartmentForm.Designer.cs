namespace ApartmentManagement
{
    partial class ApartmentForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxApartName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DGVApartment = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRented = new System.Windows.Forms.Button();
            this.btnAvialable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Floors = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVApartment)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.btnDelete);
            this.TopPanel.Controls.Add(this.tbxEmail);
            this.TopPanel.Controls.Add(this.tbxApartName);
            this.TopPanel.Controls.Add(this.label);
            this.TopPanel.Controls.Add(this.btnUpdate);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.btnInsert);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.tbxID);
            this.TopPanel.Controls.Add(this.tbxLocation);
            this.TopPanel.Controls.Add(this.tbxPhone);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(680, 193);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(428, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 27);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(127, 99);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(170, 31);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxApartName
            // 
            this.tbxApartName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApartName.Location = new System.Drawing.Point(127, 45);
            this.tbxApartName.Name = "tbxApartName";
            this.tbxApartName.Size = new System.Drawing.Size(170, 31);
            this.tbxApartName.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(7, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 28);
            this.label.TabIndex = 11;
            this.label.Text = "OwnerEmail";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(291, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 27);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "ApartName";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(141, 155);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 27);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "OwnerPhone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "ApartmentID";
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(127, 5);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(170, 31);
            this.tbxID.TabIndex = 7;
            // 
            // tbxLocation
            // 
            this.tbxLocation.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLocation.Location = new System.Drawing.Point(414, 46);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(170, 31);
            this.tbxLocation.TabIndex = 8;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(414, 5);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(170, 31);
            this.tbxPhone.TabIndex = 9;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DGVApartment);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(144, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(680, 439);
            this.BottomPanel.TabIndex = 4;
            // 
            // DGVApartment
            // 
            this.DGVApartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVApartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVApartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVApartment.Location = new System.Drawing.Point(0, 193);
            this.DGVApartment.Name = "DGVApartment";
            this.DGVApartment.Size = new System.Drawing.Size(680, 246);
            this.DGVApartment.TabIndex = 1;
            this.DGVApartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVApartment_CellClick);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(0, 243);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 44);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnRented
            // 
            this.btnRented.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRented.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnRented.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.btnRented.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRented.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRented.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRented.Location = new System.Drawing.Point(0, 199);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(144, 44);
            this.btnRented.TabIndex = 0;
            this.btnRented.Text = "Rented";
            this.btnRented.UseVisualStyleBackColor = true;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click);
            // 
            // btnAvialable
            // 
            this.btnAvialable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvialable.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnAvialable.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.btnAvialable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAvialable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAvialable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvialable.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvialable.Location = new System.Drawing.Point(0, 155);
            this.btnAvialable.Name = "btnAvialable";
            this.btnAvialable.Size = new System.Drawing.Size(144, 44);
            this.btnAvialable.TabIndex = 0;
            this.btnAvialable.Text = "Avialable";
            this.btnAvialable.UseVisualStyleBackColor = true;
            this.btnAvialable.Click += new System.EventHandler(this.btnAvialable_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apartments";
            this.button1.UseVisualStyleBackColor = true;
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
            this.LeftPanel.Controls.Add(this.Floors);
            this.LeftPanel.Controls.Add(this.btnReport);
            this.LeftPanel.Controls.Add(this.btnRented);
            this.LeftPanel.Controls.Add(this.btnAvialable);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 439);
            this.LeftPanel.TabIndex = 3;
            // 
            // Floors
            // 
            this.Floors.Dock = System.Windows.Forms.DockStyle.Top;
            this.Floors.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.Floors.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.Floors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Floors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Floors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floors.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floors.Location = new System.Drawing.Point(0, 287);
            this.Floors.Name = "Floors";
            this.Floors.Size = new System.Drawing.Size(144, 44);
            this.Floors.TabIndex = 0;
            this.Floors.Text = "Floors";
            this.Floors.UseVisualStyleBackColor = true;
            this.Floors.Click += new System.EventHandler(this.Floors_Click);
            // 
            // ApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 439);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "ApartmentForm";
            this.Text = "ApartmentForm";
            this.Load += new System.EventHandler(this.ApartmentForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVApartment)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView DGVApartment;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRented;
        private System.Windows.Forms.Button btnAvialable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button Floors;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxApartName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.TextBox tbxPhone;
    }
}