namespace ApartmentManagement
{
    partial class PaymentForm
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
            this.MaintenancePayment = new System.Windows.Forms.Button();
            this.RentPayment = new System.Windows.Forms.Button();
            this.Recipt = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payDate = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.PayPanel = new System.Windows.Forms.Panel();
            this.ReqID = new System.Windows.Forms.TextBox();
            this.comboFeeTpye = new System.Windows.Forms.ComboBox();
            this.comFloor = new System.Windows.Forms.ComboBox();
            this.comApart = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.insertPay = new System.Windows.Forms.Button();
            this.tenantID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payID = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.DGVPayRec = new System.Windows.Forms.DataGridView();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.PayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayRec)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.MaintenancePayment);
            this.LeftPanel.Controls.Add(this.RentPayment);
            this.LeftPanel.Controls.Add(this.Recipt);
            this.LeftPanel.Controls.Add(this.Payment);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(144, 450);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // MaintenancePayment
            // 
            this.MaintenancePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaintenancePayment.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.MaintenancePayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.MaintenancePayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.MaintenancePayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.MaintenancePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaintenancePayment.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenancePayment.Location = new System.Drawing.Point(0, 252);
            this.MaintenancePayment.Name = "MaintenancePayment";
            this.MaintenancePayment.Size = new System.Drawing.Size(144, 59);
            this.MaintenancePayment.TabIndex = 0;
            this.MaintenancePayment.Text = "Maintenance Payment";
            this.MaintenancePayment.UseVisualStyleBackColor = true;
            // 
            // RentPayment
            // 
            this.RentPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentPayment.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.RentPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.RentPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RentPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.RentPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentPayment.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentPayment.Location = new System.Drawing.Point(0, 207);
            this.RentPayment.Name = "RentPayment";
            this.RentPayment.Size = new System.Drawing.Size(144, 45);
            this.RentPayment.TabIndex = 0;
            this.RentPayment.Text = "Rent Payment";
            this.RentPayment.UseVisualStyleBackColor = true;
            this.RentPayment.Click += new System.EventHandler(this.PaymentRecords_Click);
            // 
            // Recipt
            // 
            this.Recipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Recipt.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.Recipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.Recipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Recipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Recipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recipt.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipt.Location = new System.Drawing.Point(0, 163);
            this.Recipt.Name = "Recipt";
            this.Recipt.Size = new System.Drawing.Size(144, 44);
            this.Recipt.TabIndex = 0;
            this.Recipt.Text = "Reecipt";
            this.Recipt.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.Payment.Dock = System.Windows.Forms.DockStyle.Top;
            this.Payment.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.Payment.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.Payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(0, 111);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(144, 52);
            this.Payment.TabIndex = 0;
            this.Payment.Text = "New Payment";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(144, 111);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Honeydew;
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.label7);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.payDate);
            this.TopPanel.Controls.Add(this.textBox5);
            this.TopPanel.Controls.Add(this.textBox4);
            this.TopPanel.Controls.Add(this.btnPay);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(144, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(656, 76);
            this.TopPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payDate
            // 
            this.payDate.CalendarFont = new System.Drawing.Font("Poppins Light", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDate.CustomFormat = "dd-MM-yyyy";
            this.payDate.Font = new System.Drawing.Font("Poppins Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.payDate.Location = new System.Drawing.Point(461, 32);
            this.payDate.Name = "payDate";
            this.payDate.Size = new System.Drawing.Size(107, 26);
            this.payDate.TabIndex = 2;
            this.payDate.Value = new System.DateTime(2023, 12, 12, 21, 30, 52, 0);
            this.payDate.ValueChanged += new System.EventHandler(this.PaymentDate_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(43, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 31);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(235, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 31);
            this.textBox4.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Location = new System.Drawing.Point(574, 12);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(70, 25);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "New Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // PaymentDate
            // 
            this.PaymentDate.CustomFormat = "dd-MM-yyyy";
            this.PaymentDate.Font = new System.Drawing.Font("Poppins Light", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PaymentDate.Location = new System.Drawing.Point(111, 150);
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Size = new System.Drawing.Size(139, 30);
            this.PaymentDate.TabIndex = 2;
            this.PaymentDate.Value = new System.DateTime(2023, 12, 12, 21, 30, 52, 0);
            this.PaymentDate.ValueChanged += new System.EventHandler(this.PaymentDate_ValueChanged);
            // 
            // PayPanel
            // 
            this.PayPanel.BackColor = System.Drawing.Color.Honeydew;
            this.PayPanel.Controls.Add(this.ReqID);
            this.PayPanel.Controls.Add(this.comboFeeTpye);
            this.PayPanel.Controls.Add(this.comFloor);
            this.PayPanel.Controls.Add(this.comApart);
            this.PayPanel.Controls.Add(this.button2);
            this.PayPanel.Controls.Add(this.PaymentDate);
            this.PayPanel.Controls.Add(this.button1);
            this.PayPanel.Controls.Add(this.insertPay);
            this.PayPanel.Controls.Add(this.tenantID);
            this.PayPanel.Controls.Add(this.label8);
            this.PayPanel.Controls.Add(this.label11);
            this.PayPanel.Controls.Add(this.label9);
            this.PayPanel.Controls.Add(this.label10);
            this.PayPanel.Controls.Add(this.label5);
            this.PayPanel.Controls.Add(this.label12);
            this.PayPanel.Controls.Add(this.label6);
            this.PayPanel.Controls.Add(this.label1);
            this.PayPanel.Controls.Add(this.payID);
            this.PayPanel.Controls.Add(this.tbxAmount);
            this.PayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PayPanel.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayPanel.Location = new System.Drawing.Point(144, 76);
            this.PayPanel.Name = "PayPanel";
            this.PayPanel.Size = new System.Drawing.Size(656, 189);
            this.PayPanel.TabIndex = 1;
            // 
            // ReqID
            // 
            this.ReqID.Location = new System.Drawing.Point(355, 149);
            this.ReqID.Name = "ReqID";
            this.ReqID.Size = new System.Drawing.Size(139, 31);
            this.ReqID.TabIndex = 6;
            // 
            // comboFeeTpye
            // 
            this.comboFeeTpye.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFeeTpye.FormattingEnabled = true;
            this.comboFeeTpye.Items.AddRange(new object[] {
            "RentFee",
            "MaintenanceFee"});
            this.comboFeeTpye.Location = new System.Drawing.Point(355, 107);
            this.comboFeeTpye.Name = "comboFeeTpye";
            this.comboFeeTpye.Size = new System.Drawing.Size(139, 31);
            this.comboFeeTpye.TabIndex = 5;
            this.comboFeeTpye.SelectedIndexChanged += new System.EventHandler(this.comboFeeTpye_SelectedIndexChanged);
            // 
            // comFloor
            // 
            this.comFloor.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFloor.FormattingEnabled = true;
            this.comFloor.Location = new System.Drawing.Point(111, 64);
            this.comFloor.Name = "comFloor";
            this.comFloor.Size = new System.Drawing.Size(139, 31);
            this.comFloor.TabIndex = 4;
            this.comFloor.SelectedIndexChanged += new System.EventHandler(this.comFloor_SelectedIndexChanged);
            // 
            // comApart
            // 
            this.comApart.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comApart.FormattingEnabled = true;
            this.comApart.Location = new System.Drawing.Point(355, 13);
            this.comApart.Name = "comApart";
            this.comApart.Size = new System.Drawing.Size(139, 31);
            this.comApart.TabIndex = 4;
            this.comApart.SelectedIndexChanged += new System.EventHandler(this.comApart_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(528, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // insertPay
            // 
            this.insertPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertPay.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPay.Location = new System.Drawing.Point(528, 12);
            this.insertPay.Name = "insertPay";
            this.insertPay.Size = new System.Drawing.Size(105, 34);
            this.insertPay.TabIndex = 1;
            this.insertPay.Text = "Pay";
            this.insertPay.UseVisualStyleBackColor = true;
            this.insertPay.Click += new System.EventHandler(this.insertPay_Click);
            // 
            // tenantID
            // 
            this.tenantID.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantID.Location = new System.Drawing.Point(111, 13);
            this.tenantID.Multiline = true;
            this.tenantID.Name = "tenantID";
            this.tenantID.Size = new System.Drawing.Size(139, 33);
            this.tenantID.TabIndex = 0;
            this.tenantID.TextChanged += new System.EventHandler(this.tenantID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "FloorNum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "PayDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "PayID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "FeeType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(268, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "RequestID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "AppartID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tenant ID";
            // 
            // payID
            // 
            this.payID.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payID.Location = new System.Drawing.Point(111, 104);
            this.payID.Multiline = true;
            this.payID.Name = "payID";
            this.payID.Size = new System.Drawing.Size(139, 32);
            this.payID.TabIndex = 0;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmount.Location = new System.Drawing.Point(355, 62);
            this.tbxAmount.Multiline = true;
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(139, 32);
            this.tbxAmount.TabIndex = 0;
            // 
            // DGVPayRec
            // 
            this.DGVPayRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPayRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPayRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPayRec.Location = new System.Drawing.Point(144, 265);
            this.DGVPayRec.Name = "DGVPayRec";
            this.DGVPayRec.Size = new System.Drawing.Size(656, 185);
            this.DGVPayRec.TabIndex = 1;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVPayRec);
            this.Controls.Add(this.PayPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.PayPanel.ResumeLayout(false);
            this.PayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayRec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button MaintenancePayment;
        private System.Windows.Forms.Button RentPayment;
        private System.Windows.Forms.Button Recipt;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.DataGridView DGVPayRec;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel PayPanel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button insertPay;
        private System.Windows.Forms.TextBox tenantID;
        private System.Windows.Forms.DateTimePicker PaymentDate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comApart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.ComboBox comFloor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox payID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboFeeTpye;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker payDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ReqID;
    }
}