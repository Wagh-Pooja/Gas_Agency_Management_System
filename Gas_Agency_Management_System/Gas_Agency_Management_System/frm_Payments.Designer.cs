namespace Gas_Agency_Management_System
{
    partial class frm_Payments
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
            this.lbl_Payment_Details = new System.Windows.Forms.Label();
            this.lbl_Connection_Charges = new System.Windows.Forms.Label();
            this.tb_Connection_Charges = new System.Windows.Forms.TextBox();
            this.lbl_Cylinder_Charges = new System.Windows.Forms.Label();
            this.tb_Cylinder_Charges = new System.Windows.Forms.TextBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Hide_Click = new System.Windows.Forms.Button();
            this.gb_Connection_Details = new System.Windows.Forms.GroupBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.gb_Extra_Services = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.tb_Stove_Charges = new System.Windows.Forms.TextBox();
            this.tb_Regulator_Charges = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Stand_Yes = new System.Windows.Forms.RadioButton();
            this.rb_Stand_No = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Stove_Yes = new System.Windows.Forms.RadioButton();
            this.rb_Stove_No = new System.Windows.Forms.RadioButton();
            this.gb_Regulator = new System.Windows.Forms.GroupBox();
            this.rb_Regulator_Yes = new System.Windows.Forms.RadioButton();
            this.rb_Regulator_No = new System.Windows.Forms.RadioButton();
            this.tb_Stand_Charges = new System.Windows.Forms.TextBox();
            this.lbl_Stand_Charges = new System.Windows.Forms.Label();
            this.lbl_Stand = new System.Windows.Forms.Label();
            this.lbl_Regulator_Charges = new System.Windows.Forms.Label();
            this.cmb_Stove_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Regulator = new System.Windows.Forms.Label();
            this.lbl_Stove_Type = new System.Windows.Forms.Label();
            this.lbl_Stove_Charges = new System.Windows.Forms.Label();
            this.lbl_Stove = new System.Windows.Forms.Label();
            this.gb_Bill_Details = new System.Windows.Forms.GroupBox();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Per = new System.Windows.Forms.Label();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Connection_Details.SuspendLayout();
            this.gb_Extra_Services.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Regulator.SuspendLayout();
            this.gb_Bill_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Payment_Details
            // 
            this.lbl_Payment_Details.AutoSize = true;
            this.lbl_Payment_Details.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Payment_Details.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Details.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Payment_Details.Location = new System.Drawing.Point(542, 29);
            this.lbl_Payment_Details.Name = "lbl_Payment_Details";
            this.lbl_Payment_Details.Size = new System.Drawing.Size(525, 77);
            this.lbl_Payment_Details.TabIndex = 0;
            this.lbl_Payment_Details.Text = "Payment Details ";
            // 
            // lbl_Connection_Charges
            // 
            this.lbl_Connection_Charges.AutoSize = true;
            this.lbl_Connection_Charges.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Connection_Charges.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Connection_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Connection_Charges.Location = new System.Drawing.Point(948, 130);
            this.lbl_Connection_Charges.Name = "lbl_Connection_Charges";
            this.lbl_Connection_Charges.Size = new System.Drawing.Size(341, 41);
            this.lbl_Connection_Charges.TabIndex = 1;
            this.lbl_Connection_Charges.Text = "Connection Charges:";
            // 
            // tb_Connection_Charges
            // 
            this.tb_Connection_Charges.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Connection_Charges.Location = new System.Drawing.Point(1305, 129);
            this.tb_Connection_Charges.MaxLength = 5;
            this.tb_Connection_Charges.Name = "tb_Connection_Charges";
            this.tb_Connection_Charges.Size = new System.Drawing.Size(279, 42);
            this.tb_Connection_Charges.TabIndex = 1;
            this.tb_Connection_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Cylinder_Charges
            // 
            this.lbl_Cylinder_Charges.AutoSize = true;
            this.lbl_Cylinder_Charges.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cylinder_Charges.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cylinder_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Cylinder_Charges.Location = new System.Drawing.Point(239, 122);
            this.lbl_Cylinder_Charges.Name = "lbl_Cylinder_Charges";
            this.lbl_Cylinder_Charges.Size = new System.Drawing.Size(302, 41);
            this.lbl_Cylinder_Charges.TabIndex = 5;
            this.lbl_Cylinder_Charges.Text = "Cylinder Charges:";
            // 
            // tb_Cylinder_Charges
            // 
            this.tb_Cylinder_Charges.Enabled = false;
            this.tb_Cylinder_Charges.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cylinder_Charges.Location = new System.Drawing.Point(559, 125);
            this.tb_Cylinder_Charges.MaxLength = 5;
            this.tb_Cylinder_Charges.Name = "tb_Cylinder_Charges";
            this.tb_Cylinder_Charges.Size = new System.Drawing.Size(358, 42);
            this.tb_Cylinder_Charges.TabIndex = 3;
            this.tb_Cylinder_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Header.Controls.Add(this.btn_Hide_Click);
            this.pnl_Header.Controls.Add(this.lbl_Payment_Details);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1648, 126);
            this.pnl_Header.TabIndex = 28;
            // 
            // btn_Hide_Click
            // 
            this.btn_Hide_Click.BackColor = System.Drawing.Color.Red;
            this.btn_Hide_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide_Click.Location = new System.Drawing.Point(1544, 10);
            this.btn_Hide_Click.Name = "btn_Hide_Click";
            this.btn_Hide_Click.Size = new System.Drawing.Size(77, 47);
            this.btn_Hide_Click.TabIndex = 63;
            this.btn_Hide_Click.Text = "X";
            this.btn_Hide_Click.UseVisualStyleBackColor = false;
            this.btn_Hide_Click.Click += new System.EventHandler(this.btn_Hide_Click_Click);
            // 
            // gb_Connection_Details
            // 
            this.gb_Connection_Details.BackColor = System.Drawing.Color.Silver;
            this.gb_Connection_Details.Controls.Add(this.tb_Customer_ID);
            this.gb_Connection_Details.Controls.Add(this.lbl_Customer_ID);
            this.gb_Connection_Details.Controls.Add(this.lbl_Connection_Charges);
            this.gb_Connection_Details.Controls.Add(this.tb_Connection_Charges);
            this.gb_Connection_Details.Controls.Add(this.lbl_Cylinder_Charges);
            this.gb_Connection_Details.Controls.Add(this.tb_Cylinder_Charges);
            this.gb_Connection_Details.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Connection_Details.Location = new System.Drawing.Point(31, 155);
            this.gb_Connection_Details.Name = "gb_Connection_Details";
            this.gb_Connection_Details.Size = new System.Drawing.Size(1592, 203);
            this.gb_Connection_Details.TabIndex = 32;
            this.gb_Connection_Details.TabStop = false;
            this.gb_Connection_Details.Text = "Connection Details";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(559, 36);
            this.tb_Customer_ID.MaxLength = 5;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(358, 42);
            this.tb_Customer_ID.TabIndex = 1;
            this.tb_Customer_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(239, 36);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(242, 41);
            this.lbl_Customer_ID.TabIndex = 6;
            this.lbl_Customer_ID.Text = "Customer ID :";
            // 
            // gb_Extra_Services
            // 
            this.gb_Extra_Services.BackColor = System.Drawing.Color.Silver;
            this.gb_Extra_Services.Controls.Add(this.btn_Calculate);
            this.gb_Extra_Services.Controls.Add(this.tb_Stove_Charges);
            this.gb_Extra_Services.Controls.Add(this.tb_Regulator_Charges);
            this.gb_Extra_Services.Controls.Add(this.groupBox2);
            this.gb_Extra_Services.Controls.Add(this.groupBox1);
            this.gb_Extra_Services.Controls.Add(this.gb_Regulator);
            this.gb_Extra_Services.Controls.Add(this.tb_Stand_Charges);
            this.gb_Extra_Services.Controls.Add(this.lbl_Stand_Charges);
            this.gb_Extra_Services.Controls.Add(this.lbl_Stand);
            this.gb_Extra_Services.Controls.Add(this.lbl_Regulator_Charges);
            this.gb_Extra_Services.Controls.Add(this.cmb_Stove_Type);
            this.gb_Extra_Services.Controls.Add(this.lbl_Regulator);
            this.gb_Extra_Services.Controls.Add(this.lbl_Stove_Type);
            this.gb_Extra_Services.Controls.Add(this.lbl_Stove_Charges);
            this.gb_Extra_Services.Controls.Add(this.lbl_Stove);
            this.gb_Extra_Services.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Extra_Services.Location = new System.Drawing.Point(31, 385);
            this.gb_Extra_Services.Name = "gb_Extra_Services";
            this.gb_Extra_Services.Size = new System.Drawing.Size(1592, 331);
            this.gb_Extra_Services.TabIndex = 33;
            this.gb_Extra_Services.TabStop = false;
            this.gb_Extra_Services.Text = "Extra Services";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calculate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.White;
            this.btn_Calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Calculate.Location = new System.Drawing.Point(1319, 204);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(173, 45);
            this.btn_Calculate.TabIndex = 78;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // tb_Stove_Charges
            // 
            this.tb_Stove_Charges.Enabled = false;
            this.tb_Stove_Charges.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stove_Charges.Location = new System.Drawing.Point(1319, 55);
            this.tb_Stove_Charges.MaxLength = 4;
            this.tb_Stove_Charges.Name = "tb_Stove_Charges";
            this.tb_Stove_Charges.Size = new System.Drawing.Size(250, 42);
            this.tb_Stove_Charges.TabIndex = 77;
            this.tb_Stove_Charges.Text = "0";
            this.tb_Stove_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Stove_Charges.Leave += new System.EventHandler(this.tb_Stove_Charges_Leave);
            // 
            // tb_Regulator_Charges
            // 
            this.tb_Regulator_Charges.Enabled = false;
            this.tb_Regulator_Charges.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Regulator_Charges.Location = new System.Drawing.Point(925, 167);
            this.tb_Regulator_Charges.MaxLength = 10;
            this.tb_Regulator_Charges.Name = "tb_Regulator_Charges";
            this.tb_Regulator_Charges.Size = new System.Drawing.Size(265, 42);
            this.tb_Regulator_Charges.TabIndex = 76;
            this.tb_Regulator_Charges.Text = "0";
            this.tb_Regulator_Charges.Leave += new System.EventHandler(this.tb_Regulator_Charges_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Stand_Yes);
            this.groupBox2.Controls.Add(this.rb_Stand_No);
            this.groupBox2.Location = new System.Drawing.Point(261, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 75);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            // 
            // rb_Stand_Yes
            // 
            this.rb_Stand_Yes.AutoSize = true;
            this.rb_Stand_Yes.Location = new System.Drawing.Point(31, 27);
            this.rb_Stand_Yes.Name = "rb_Stand_Yes";
            this.rb_Stand_Yes.Size = new System.Drawing.Size(84, 34);
            this.rb_Stand_Yes.TabIndex = 68;
            this.rb_Stand_Yes.TabStop = true;
            this.rb_Stand_Yes.Text = "Yes";
            this.rb_Stand_Yes.UseVisualStyleBackColor = true;
            this.rb_Stand_Yes.CheckedChanged += new System.EventHandler(this.rb_Stand_Yes_Checked_Change);
            // 
            // rb_Stand_No
            // 
            this.rb_Stand_No.AutoSize = true;
            this.rb_Stand_No.Location = new System.Drawing.Point(145, 27);
            this.rb_Stand_No.Name = "rb_Stand_No";
            this.rb_Stand_No.Size = new System.Drawing.Size(74, 34);
            this.rb_Stand_No.TabIndex = 69;
            this.rb_Stand_No.TabStop = true;
            this.rb_Stand_No.Text = "No";
            this.rb_Stand_No.UseVisualStyleBackColor = true;
            this.rb_Stand_No.CheckedChanged += new System.EventHandler(this.rb_Stand_No_Checked_Change);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Stove_Yes);
            this.groupBox1.Controls.Add(this.rb_Stove_No);
            this.groupBox1.Location = new System.Drawing.Point(261, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 75);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // rb_Stove_Yes
            // 
            this.rb_Stove_Yes.AutoSize = true;
            this.rb_Stove_Yes.Location = new System.Drawing.Point(31, 27);
            this.rb_Stove_Yes.Name = "rb_Stove_Yes";
            this.rb_Stove_Yes.Size = new System.Drawing.Size(84, 34);
            this.rb_Stove_Yes.TabIndex = 68;
            this.rb_Stove_Yes.TabStop = true;
            this.rb_Stove_Yes.Text = "Yes";
            this.rb_Stove_Yes.UseVisualStyleBackColor = true;
            this.rb_Stove_Yes.CheckedChanged += new System.EventHandler(this.Stov_Yes_Checked_Change);
            // 
            // rb_Stove_No
            // 
            this.rb_Stove_No.AutoSize = true;
            this.rb_Stove_No.Location = new System.Drawing.Point(154, 27);
            this.rb_Stove_No.Name = "rb_Stove_No";
            this.rb_Stove_No.Size = new System.Drawing.Size(74, 34);
            this.rb_Stove_No.TabIndex = 69;
            this.rb_Stove_No.TabStop = true;
            this.rb_Stove_No.Text = "No";
            this.rb_Stove_No.UseVisualStyleBackColor = true;
            this.rb_Stove_No.CheckedChanged += new System.EventHandler(this.Stove_No_Checked_Change);
            // 
            // gb_Regulator
            // 
            this.gb_Regulator.Controls.Add(this.rb_Regulator_Yes);
            this.gb_Regulator.Controls.Add(this.rb_Regulator_No);
            this.gb_Regulator.Location = new System.Drawing.Point(261, 134);
            this.gb_Regulator.Name = "gb_Regulator";
            this.gb_Regulator.Size = new System.Drawing.Size(264, 75);
            this.gb_Regulator.TabIndex = 72;
            this.gb_Regulator.TabStop = false;
            // 
            // rb_Regulator_Yes
            // 
            this.rb_Regulator_Yes.AutoSize = true;
            this.rb_Regulator_Yes.Location = new System.Drawing.Point(31, 27);
            this.rb_Regulator_Yes.Name = "rb_Regulator_Yes";
            this.rb_Regulator_Yes.Size = new System.Drawing.Size(84, 34);
            this.rb_Regulator_Yes.TabIndex = 68;
            this.rb_Regulator_Yes.TabStop = true;
            this.rb_Regulator_Yes.Text = "Yes";
            this.rb_Regulator_Yes.UseVisualStyleBackColor = true;
            this.rb_Regulator_Yes.CheckedChanged += new System.EventHandler(this.rb_Regulator_Yes_Checked_Change);
            // 
            // rb_Regulator_No
            // 
            this.rb_Regulator_No.AutoSize = true;
            this.rb_Regulator_No.Location = new System.Drawing.Point(145, 27);
            this.rb_Regulator_No.Name = "rb_Regulator_No";
            this.rb_Regulator_No.Size = new System.Drawing.Size(74, 34);
            this.rb_Regulator_No.TabIndex = 69;
            this.rb_Regulator_No.TabStop = true;
            this.rb_Regulator_No.Text = "No";
            this.rb_Regulator_No.UseVisualStyleBackColor = true;
            this.rb_Regulator_No.CheckedChanged += new System.EventHandler(this.rb_Regulator_No_Checked_Change);
            // 
            // tb_Stand_Charges
            // 
            this.tb_Stand_Charges.Enabled = false;
            this.tb_Stand_Charges.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stand_Charges.Location = new System.Drawing.Point(925, 254);
            this.tb_Stand_Charges.MaxLength = 4;
            this.tb_Stand_Charges.Name = "tb_Stand_Charges";
            this.tb_Stand_Charges.Size = new System.Drawing.Size(265, 42);
            this.tb_Stand_Charges.TabIndex = 65;
            this.tb_Stand_Charges.Text = "0";
            this.tb_Stand_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Stand_Charges.Leave += new System.EventHandler(this.tb_Stand_Charges_Leave);
            // 
            // lbl_Stand_Charges
            // 
            this.lbl_Stand_Charges.AutoSize = true;
            this.lbl_Stand_Charges.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stand_Charges.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stand_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stand_Charges.Location = new System.Drawing.Point(563, 256);
            this.lbl_Stand_Charges.Name = "lbl_Stand_Charges";
            this.lbl_Stand_Charges.Size = new System.Drawing.Size(266, 41);
            this.lbl_Stand_Charges.TabIndex = 64;
            this.lbl_Stand_Charges.Text = "Stand Charges :";
            // 
            // lbl_Stand
            // 
            this.lbl_Stand.AutoSize = true;
            this.lbl_Stand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stand.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stand.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stand.Location = new System.Drawing.Point(12, 256);
            this.lbl_Stand.Name = "lbl_Stand";
            this.lbl_Stand.Size = new System.Drawing.Size(130, 41);
            this.lbl_Stand.TabIndex = 63;
            this.lbl_Stand.Text = "Stand :";
            // 
            // lbl_Regulator_Charges
            // 
            this.lbl_Regulator_Charges.AutoSize = true;
            this.lbl_Regulator_Charges.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Regulator_Charges.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Regulator_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Regulator_Charges.Location = new System.Drawing.Point(563, 165);
            this.lbl_Regulator_Charges.Name = "lbl_Regulator_Charges";
            this.lbl_Regulator_Charges.Size = new System.Drawing.Size(333, 41);
            this.lbl_Regulator_Charges.TabIndex = 59;
            this.lbl_Regulator_Charges.Text = "Regulator Charges :";
            // 
            // cmb_Stove_Type
            // 
            this.cmb_Stove_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stove_Type.Enabled = false;
            this.cmb_Stove_Type.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stove_Type.FormattingEnabled = true;
            this.cmb_Stove_Type.Items.AddRange(new object[] {
            "Single Stove",
            "Double Stove",
            "Triple Stove"});
            this.cmb_Stove_Type.Location = new System.Drawing.Point(787, 58);
            this.cmb_Stove_Type.Name = "cmb_Stove_Type";
            this.cmb_Stove_Type.Size = new System.Drawing.Size(265, 42);
            this.cmb_Stove_Type.TabIndex = 57;
            // 
            // lbl_Regulator
            // 
            this.lbl_Regulator.AutoSize = true;
            this.lbl_Regulator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Regulator.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Regulator.ForeColor = System.Drawing.Color.Black;
            this.lbl_Regulator.Location = new System.Drawing.Point(12, 154);
            this.lbl_Regulator.Name = "lbl_Regulator";
            this.lbl_Regulator.Size = new System.Drawing.Size(197, 41);
            this.lbl_Regulator.TabIndex = 58;
            this.lbl_Regulator.Text = "Regulator :";
            // 
            // lbl_Stove_Type
            // 
            this.lbl_Stove_Type.AutoSize = true;
            this.lbl_Stove_Type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stove_Type.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stove_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stove_Type.Location = new System.Drawing.Point(563, 56);
            this.lbl_Stove_Type.Name = "lbl_Stove_Type";
            this.lbl_Stove_Type.Size = new System.Drawing.Size(218, 41);
            this.lbl_Stove_Type.TabIndex = 61;
            this.lbl_Stove_Type.Text = " Stove Type :";
            // 
            // lbl_Stove_Charges
            // 
            this.lbl_Stove_Charges.AutoSize = true;
            this.lbl_Stove_Charges.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stove_Charges.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stove_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stove_Charges.Location = new System.Drawing.Point(1066, 58);
            this.lbl_Stove_Charges.Name = "lbl_Stove_Charges";
            this.lbl_Stove_Charges.Size = new System.Drawing.Size(247, 41);
            this.lbl_Stove_Charges.TabIndex = 62;
            this.lbl_Stove_Charges.Text = "Stove Charges:";
            // 
            // lbl_Stove
            // 
            this.lbl_Stove.AutoSize = true;
            this.lbl_Stove.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stove.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stove.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stove.Location = new System.Drawing.Point(23, 59);
            this.lbl_Stove.Name = "lbl_Stove";
            this.lbl_Stove.Size = new System.Drawing.Size(121, 41);
            this.lbl_Stove.TabIndex = 60;
            this.lbl_Stove.Text = "Stove :";
            // 
            // gb_Bill_Details
            // 
            this.gb_Bill_Details.BackColor = System.Drawing.Color.Silver;
            this.gb_Bill_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_Per);
            this.gb_Bill_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Bill_Details.Controls.Add(this.tb_GST);
            this.gb_Bill_Details.Controls.Add(this.lbl_GST);
            this.gb_Bill_Details.Controls.Add(this.tb_Total);
            this.gb_Bill_Details.Controls.Add(this.lbl_Total);
            this.gb_Bill_Details.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bill_Details.Location = new System.Drawing.Point(31, 748);
            this.gb_Bill_Details.Name = "gb_Bill_Details";
            this.gb_Bill_Details.Size = new System.Drawing.Size(1586, 153);
            this.gb_Bill_Details.TabIndex = 34;
            this.gb_Bill_Details.TabStop = false;
            this.gb_Bill_Details.Text = "Bill Details";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1365, 67);
            this.tb_Final_Bill.MaxLength = 4;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(204, 42);
            this.tb_Final_Bill.TabIndex = 62;
            this.tb_Final_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Per
            // 
            this.lbl_Per.AutoSize = true;
            this.lbl_Per.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per.Location = new System.Drawing.Point(972, 67);
            this.lbl_Per.Name = "lbl_Per";
            this.lbl_Per.Size = new System.Drawing.Size(43, 37);
            this.lbl_Per.TabIndex = 61;
            this.lbl_Per.Text = "%";
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(1123, 64);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(205, 41);
            this.lbl_Final_Bill.TabIndex = 60;
            this.lbl_Final_Bill.Text = "Final Bill :";
            // 
            // tb_GST
            // 
            this.tb_GST.Enabled = false;
            this.tb_GST.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(761, 66);
            this.tb_GST.MaxLength = 4;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(196, 42);
            this.tb_GST.TabIndex = 57;
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GST.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.Black;
            this.lbl_GST.Location = new System.Drawing.Point(574, 71);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(109, 41);
            this.lbl_GST.TabIndex = 59;
            this.lbl_GST.Text = "GST :";
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(246, 70);
            this.tb_Total.MaxLength = 5;
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(279, 42);
            this.tb_Total.TabIndex = 56;
            this.tb_Total.Text = "0";
            this.tb_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Black;
            this.lbl_Total.Location = new System.Drawing.Point(21, 63);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(123, 41);
            this.lbl_Total.TabIndex = 58;
            this.lbl_Total.Text = "Total :";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(638, 924);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(338, 69);
            this.btn_Save.TabIndex = 35;
            this.btn_Save.Text = "Save && Print";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1648, 1005);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Bill_Details);
            this.Controls.Add(this.gb_Extra_Services);
            this.Controls.Add(this.gb_Connection_Details);
            this.Controls.Add(this.pnl_Header);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Payments_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Connection_Details.ResumeLayout(false);
            this.gb_Connection_Details.PerformLayout();
            this.gb_Extra_Services.ResumeLayout(false);
            this.gb_Extra_Services.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Regulator.ResumeLayout(false);
            this.gb_Regulator.PerformLayout();
            this.gb_Bill_Details.ResumeLayout(false);
            this.gb_Bill_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Payment_Details;
        private System.Windows.Forms.Label lbl_Connection_Charges;
        private System.Windows.Forms.TextBox tb_Connection_Charges;
        private System.Windows.Forms.Label lbl_Cylinder_Charges;
        private System.Windows.Forms.TextBox tb_Cylinder_Charges;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.GroupBox gb_Connection_Details;
        private System.Windows.Forms.GroupBox gb_Extra_Services;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Stand_Yes;
        private System.Windows.Forms.RadioButton rb_Stand_No;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Stove_Yes;
        private System.Windows.Forms.RadioButton rb_Stove_No;
        private System.Windows.Forms.GroupBox gb_Regulator;
        private System.Windows.Forms.RadioButton rb_Regulator_Yes;
        private System.Windows.Forms.RadioButton rb_Regulator_No;
        private System.Windows.Forms.TextBox tb_Stand_Charges;
        private System.Windows.Forms.Label lbl_Stand_Charges;
        private System.Windows.Forms.Label lbl_Stand;
        private System.Windows.Forms.ComboBox cmb_Stove_Type;
        private System.Windows.Forms.Label lbl_Stove_Type;
        private System.Windows.Forms.Label lbl_Stove_Charges;
        private System.Windows.Forms.Label lbl_Stove;
        private System.Windows.Forms.Label lbl_Regulator_Charges;
        private System.Windows.Forms.Label lbl_Regulator;
        private System.Windows.Forms.GroupBox gb_Bill_Details;
        private System.Windows.Forms.Label lbl_Per;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Button btn_Hide_Click;
        private System.Windows.Forms.TextBox tb_Regulator_Charges;
        private System.Windows.Forms.TextBox tb_Stove_Charges;
        private System.Windows.Forms.Button btn_Calculate;
    }
}