namespace Gas_Agency_Management_System
{
    partial class frm_Add_New_Booking
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
            this.dtp_Previous_Booking = new System.Windows.Forms.Panel();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.lbl_New_Booking = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Previous_Book = new System.Windows.Forms.DateTimePicker();
            this.dtp_Booking_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Payment = new System.Windows.Forms.TextBox();
            this.tb_Cylinder_Price = new System.Windows.Forms.TextBox();
            this.tb_No_of_Cylinder = new System.Windows.Forms.TextBox();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.lbl_Delivery_Boy = new System.Windows.Forms.Label();
            this.lbl_Previous_Booking = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.tb_Booking_ID = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Area = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_No_of_Cylinder = new System.Windows.Forms.Label();
            this.lbl_Cylinder_Price = new System.Windows.Forms.Label();
            this.lbl_Cylinder_Type = new System.Windows.Forms.Label();
            this.lbl_Booking_Date = new System.Windows.Forms.Label();
            this.lbl_Booking_ID = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.cmb_Cylinder_Type = new System.Windows.Forms.ComboBox();
            this.rb_Mob_No = new System.Windows.Forms.RadioButton();
            this.rb_Customer_ID = new System.Windows.Forms.RadioButton();
            this.cmb_Delivery_Boy = new System.Windows.Forms.ComboBox();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.dtp_Previous_Booking.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Previous_Booking
            // 
            this.dtp_Previous_Booking.BackColor = System.Drawing.Color.DarkBlue;
            this.dtp_Previous_Booking.Controls.Add(this.btn_Hide);
            this.dtp_Previous_Booking.Controls.Add(this.lbl_New_Booking);
            this.dtp_Previous_Booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_Previous_Booking.Location = new System.Drawing.Point(0, 0);
            this.dtp_Previous_Booking.Name = "dtp_Previous_Booking";
            this.dtp_Previous_Booking.Size = new System.Drawing.Size(1674, 135);
            this.dtp_Previous_Booking.TabIndex = 96;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.ForeColor = System.Drawing.Color.White;
            this.btn_Hide.Location = new System.Drawing.Point(1598, 0);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(76, 46);
            this.btn_Hide.TabIndex = 98;
            this.btn_Hide.Text = "X";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // lbl_New_Booking
            // 
            this.lbl_New_Booking.AutoSize = true;
            this.lbl_New_Booking.BackColor = System.Drawing.Color.Transparent;
            this.lbl_New_Booking.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Booking.ForeColor = System.Drawing.Color.White;
            this.lbl_New_Booking.Location = new System.Drawing.Point(508, 34);
            this.lbl_New_Booking.Name = "lbl_New_Booking";
            this.lbl_New_Booking.Size = new System.Drawing.Size(560, 75);
            this.lbl_New_Booking.TabIndex = 0;
            this.lbl_New_Booking.Text = "Add New Booking";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(750, 374);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(172, 55);
            this.btn_Search.TabIndex = 73;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_Previous_Book
            // 
            this.dtp_Previous_Book.Enabled = false;
            this.dtp_Previous_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Previous_Book.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Previous_Book.Location = new System.Drawing.Point(1297, 561);
            this.dtp_Previous_Book.Name = "dtp_Previous_Book";
            this.dtp_Previous_Book.Size = new System.Drawing.Size(365, 44);
            this.dtp_Previous_Book.TabIndex = 94;
            // 
            // dtp_Booking_Date
            // 
            this.dtp_Booking_Date.Enabled = false;
            this.dtp_Booking_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Booking_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Booking_Date.Location = new System.Drawing.Point(1297, 180);
            this.dtp_Booking_Date.Name = "dtp_Booking_Date";
            this.dtp_Booking_Date.Size = new System.Drawing.Size(365, 44);
            this.dtp_Booking_Date.TabIndex = 74;
            // 
            // tb_Payment
            // 
            this.tb_Payment.Enabled = false;
            this.tb_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Payment.Location = new System.Drawing.Point(820, 770);
            this.tb_Payment.MaxLength = 10;
            this.tb_Payment.Name = "tb_Payment";
            this.tb_Payment.Size = new System.Drawing.Size(214, 44);
            this.tb_Payment.TabIndex = 77;
            // 
            // tb_Cylinder_Price
            // 
            this.tb_Cylinder_Price.Enabled = false;
            this.tb_Cylinder_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cylinder_Price.Location = new System.Drawing.Point(348, 767);
            this.tb_Cylinder_Price.MaxLength = 10;
            this.tb_Cylinder_Price.Name = "tb_Cylinder_Price";
            this.tb_Cylinder_Price.Size = new System.Drawing.Size(233, 44);
            this.tb_Cylinder_Price.TabIndex = 95;
            // 
            // tb_No_of_Cylinder
            // 
            this.tb_No_of_Cylinder.Enabled = false;
            this.tb_No_of_Cylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_No_of_Cylinder.Location = new System.Drawing.Point(1297, 477);
            this.tb_No_of_Cylinder.MaxLength = 10;
            this.tb_No_of_Cylinder.Name = "tb_No_of_Cylinder";
            this.tb_No_of_Cylinder.Size = new System.Drawing.Size(365, 44);
            this.tb_No_of_Cylinder.TabIndex = 76;
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Payment.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment.Location = new System.Drawing.Point(623, 768);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(197, 46);
            this.lbl_Payment.TabIndex = 92;
            this.lbl_Payment.Text = "Payment :";
            // 
            // lbl_Delivery_Boy
            // 
            this.lbl_Delivery_Boy.AutoSize = true;
            this.lbl_Delivery_Boy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Delivery_Boy.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delivery_Boy.Location = new System.Drawing.Point(1101, 768);
            this.lbl_Delivery_Boy.Name = "lbl_Delivery_Boy";
            this.lbl_Delivery_Boy.Size = new System.Drawing.Size(257, 43);
            this.lbl_Delivery_Boy.TabIndex = 93;
            this.lbl_Delivery_Boy.Text = "Delivery Boy :";
            // 
            // lbl_Previous_Booking
            // 
            this.lbl_Previous_Booking.AutoSize = true;
            this.lbl_Previous_Booking.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Previous_Booking.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Previous_Booking.Location = new System.Drawing.Point(941, 564);
            this.lbl_Previous_Booking.Name = "lbl_Previous_Booking";
            this.lbl_Previous_Booking.Size = new System.Drawing.Size(328, 43);
            this.lbl_Previous_Booking.TabIndex = 91;
            this.lbl_Previous_Booking.Text = "Previous Booking :";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(335, 471);
            this.tb_Customer_ID.MaxLength = 20;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(381, 48);
            this.tb_Customer_ID.TabIndex = 90;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(9, 476);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(248, 43);
            this.lbl_Customer_ID.TabIndex = 89;
            this.lbl_Customer_ID.Text = "Customer ID :";
            // 
            // tb_Booking_ID
            // 
            this.tb_Booking_ID.Enabled = false;
            this.tb_Booking_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Booking_ID.Location = new System.Drawing.Point(335, 180);
            this.tb_Booking_ID.MaxLength = 10;
            this.tb_Booking_ID.Name = "tb_Booking_ID";
            this.tb_Booking_ID.Size = new System.Drawing.Size(381, 44);
            this.tb_Booking_ID.TabIndex = 71;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(335, 375);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(381, 44);
            this.tb_Mobile_No.TabIndex = 72;
            // 
            // tb_Area
            // 
            this.tb_Area.Enabled = false;
            this.tb_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Area.Location = new System.Drawing.Point(335, 562);
            this.tb_Area.MaxLength = 30;
            this.tb_Area.Name = "tb_Area";
            this.tb_Area.Size = new System.Drawing.Size(381, 48);
            this.tb_Area.TabIndex = 88;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Enabled = false;
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(335, 271);
            this.tb_Customer_Name.MaxLength = 20;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(775, 48);
            this.tb_Customer_Name.TabIndex = 87;
            // 
            // lbl_No_of_Cylinder
            // 
            this.lbl_No_of_Cylinder.AutoSize = true;
            this.lbl_No_of_Cylinder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_No_of_Cylinder.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No_of_Cylinder.Location = new System.Drawing.Point(941, 477);
            this.lbl_No_of_Cylinder.Name = "lbl_No_of_Cylinder";
            this.lbl_No_of_Cylinder.Size = new System.Drawing.Size(282, 43);
            this.lbl_No_of_Cylinder.TabIndex = 86;
            this.lbl_No_of_Cylinder.Text = "No of Cylinder :";
            // 
            // lbl_Cylinder_Price
            // 
            this.lbl_Cylinder_Price.AutoSize = true;
            this.lbl_Cylinder_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cylinder_Price.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cylinder_Price.Location = new System.Drawing.Point(22, 765);
            this.lbl_Cylinder_Price.Name = "lbl_Cylinder_Price";
            this.lbl_Cylinder_Price.Size = new System.Drawing.Size(272, 43);
            this.lbl_Cylinder_Price.TabIndex = 85;
            this.lbl_Cylinder_Price.Text = "Cylinder Price :";
            // 
            // lbl_Cylinder_Type
            // 
            this.lbl_Cylinder_Type.AutoSize = true;
            this.lbl_Cylinder_Type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cylinder_Type.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cylinder_Type.Location = new System.Drawing.Point(941, 381);
            this.lbl_Cylinder_Type.Name = "lbl_Cylinder_Type";
            this.lbl_Cylinder_Type.Size = new System.Drawing.Size(272, 43);
            this.lbl_Cylinder_Type.TabIndex = 84;
            this.lbl_Cylinder_Type.Text = "Cylinder Type :";
            // 
            // lbl_Booking_Date
            // 
            this.lbl_Booking_Date.AutoSize = true;
            this.lbl_Booking_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Booking_Date.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Booking_Date.Location = new System.Drawing.Point(941, 178);
            this.lbl_Booking_Date.Name = "lbl_Booking_Date";
            this.lbl_Booking_Date.Size = new System.Drawing.Size(264, 43);
            this.lbl_Booking_Date.TabIndex = 83;
            this.lbl_Booking_Date.Text = "Booking Date :";
            // 
            // lbl_Booking_ID
            // 
            this.lbl_Booking_ID.AutoSize = true;
            this.lbl_Booking_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Booking_ID.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Booking_ID.Location = new System.Drawing.Point(9, 181);
            this.lbl_Booking_ID.Name = "lbl_Booking_ID";
            this.lbl_Booking_ID.Size = new System.Drawing.Size(230, 43);
            this.lbl_Booking_ID.TabIndex = 82;
            this.lbl_Booking_ID.Text = "Booking ID :";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(12, 373);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(215, 43);
            this.lbl_Mobile_No.TabIndex = 81;
            this.lbl_Mobile_No.Text = "Mobile No :";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Area.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Area.Location = new System.Drawing.Point(9, 562);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(118, 43);
            this.lbl_Area.TabIndex = 80;
            this.lbl_Area.Text = "Area :";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(9, 271);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(302, 43);
            this.lbl_Customer_Name.TabIndex = 75;
            this.lbl_Customer_Name.Text = "Customer Name :";
            // 
            // cmb_Cylinder_Type
            // 
            this.cmb_Cylinder_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cylinder_Type.Enabled = false;
            this.cmb_Cylinder_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmb_Cylinder_Type.FormattingEnabled = true;
            this.cmb_Cylinder_Type.Items.AddRange(new object[] {
            "Domestic",
            "Commercial"});
            this.cmb_Cylinder_Type.Location = new System.Drawing.Point(1297, 376);
            this.cmb_Cylinder_Type.Name = "cmb_Cylinder_Type";
            this.cmb_Cylinder_Type.Size = new System.Drawing.Size(365, 48);
            this.cmb_Cylinder_Type.TabIndex = 98;
            // 
            // rb_Mob_No
            // 
            this.rb_Mob_No.AutoSize = true;
            this.rb_Mob_No.Location = new System.Drawing.Point(297, 391);
            this.rb_Mob_No.Name = "rb_Mob_No";
            this.rb_Mob_No.Size = new System.Drawing.Size(21, 20);
            this.rb_Mob_No.TabIndex = 99;
            this.rb_Mob_No.TabStop = true;
            this.rb_Mob_No.UseVisualStyleBackColor = true;
            this.rb_Mob_No.CheckedChanged += new System.EventHandler(this.Mobile_Checked_Change);
            // 
            // rb_Customer_ID
            // 
            this.rb_Customer_ID.AutoSize = true;
            this.rb_Customer_ID.Location = new System.Drawing.Point(297, 491);
            this.rb_Customer_ID.Name = "rb_Customer_ID";
            this.rb_Customer_ID.Size = new System.Drawing.Size(21, 20);
            this.rb_Customer_ID.TabIndex = 100;
            this.rb_Customer_ID.TabStop = true;
            this.rb_Customer_ID.UseVisualStyleBackColor = true;
            this.rb_Customer_ID.CheckedChanged += new System.EventHandler(this.Customer_ID_Checked_Change);
            // 
            // cmb_Delivery_Boy
            // 
            this.cmb_Delivery_Boy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Delivery_Boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmb_Delivery_Boy.FormattingEnabled = true;
            this.cmb_Delivery_Boy.Items.AddRange(new object[] {
            "Arun Lad",
            "Satish Shinde",
            "Kuldip Mane",
            "Mahesh Kadam"});
            this.cmb_Delivery_Boy.Location = new System.Drawing.Point(1397, 763);
            this.cmb_Delivery_Boy.Name = "cmb_Delivery_Boy";
            this.cmb_Delivery_Boy.Size = new System.Drawing.Size(265, 48);
            this.cmb_Delivery_Boy.TabIndex = 101;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Book.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Book.Location = new System.Drawing.Point(879, 884);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(303, 55);
            this.btn_Book.TabIndex = 102;
            this.btn_Book.Text = "Book && Print";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Reset.Location = new System.Drawing.Point(564, 884);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(172, 55);
            this.btn_Reset.TabIndex = 103;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frm_Add_New_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1674, 973);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.cmb_Delivery_Boy);
            this.Controls.Add(this.rb_Customer_ID);
            this.Controls.Add(this.rb_Mob_No);
            this.Controls.Add(this.cmb_Cylinder_Type);
            this.Controls.Add(this.dtp_Previous_Booking);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_Previous_Book);
            this.Controls.Add(this.dtp_Booking_Date);
            this.Controls.Add(this.tb_Payment);
            this.Controls.Add(this.tb_Cylinder_Price);
            this.Controls.Add(this.tb_No_of_Cylinder);
            this.Controls.Add(this.lbl_Payment);
            this.Controls.Add(this.lbl_Delivery_Boy);
            this.Controls.Add(this.lbl_Previous_Booking);
            this.Controls.Add(this.tb_Customer_ID);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Controls.Add(this.tb_Booking_ID);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Area);
            this.Controls.Add(this.tb_Customer_Name);
            this.Controls.Add(this.lbl_No_of_Cylinder);
            this.Controls.Add(this.lbl_Cylinder_Price);
            this.Controls.Add(this.lbl_Cylinder_Type);
            this.Controls.Add(this.lbl_Booking_Date);
            this.Controls.Add(this.lbl_Booking_ID);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_Customer_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_New_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Booking_Load);
            this.dtp_Previous_Booking.ResumeLayout(false);
            this.dtp_Previous_Booking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dtp_Previous_Booking;
        private System.Windows.Forms.Label lbl_New_Booking;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_Previous_Book;
        private System.Windows.Forms.DateTimePicker dtp_Booking_Date;
        private System.Windows.Forms.TextBox tb_Payment;
        private System.Windows.Forms.TextBox tb_Cylinder_Price;
        private System.Windows.Forms.TextBox tb_No_of_Cylinder;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.Label lbl_Delivery_Boy;
        private System.Windows.Forms.Label lbl_Previous_Booking;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.TextBox tb_Booking_ID;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Area;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Label lbl_No_of_Cylinder;
        private System.Windows.Forms.Label lbl_Cylinder_Price;
        private System.Windows.Forms.Label lbl_Cylinder_Type;
        private System.Windows.Forms.Label lbl_Booking_Date;
        private System.Windows.Forms.Label lbl_Booking_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.ComboBox cmb_Cylinder_Type;
        private System.Windows.Forms.RadioButton rb_Mob_No;
        private System.Windows.Forms.RadioButton rb_Customer_ID;
        private System.Windows.Forms.ComboBox cmb_Delivery_Boy;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Reset;
    }
}