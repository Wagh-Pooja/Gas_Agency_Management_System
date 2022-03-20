namespace Gas_Agency_Management_System
{
    partial class frm_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stock));
            this.lbl_Cylinder_Type = new System.Windows.Forms.Label();
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Current_Stock = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date_of_Entries = new System.Windows.Forms.DateTimePicker();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_Cylinder_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Stock_ID = new System.Windows.Forms.Label();
            this.tb_Stock_ID = new System.Windows.Forms.TextBox();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.gb_Stock = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Available_Stock = new System.Windows.Forms.TextBox();
            this.lbl_Sale_Stock = new System.Windows.Forms.Label();
            this.lbl_Availabl_Stock = new System.Windows.Forms.Label();
            this.tb_Sale_Stock = new System.Windows.Forms.TextBox();
            this.cmb_Cylinder = new System.Windows.Forms.ComboBox();
            this.tb_Cylinder_Type = new System.Windows.Forms.Panel();
            this.gb_Stock_Details.SuspendLayout();
            this.gb_Stock.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tb_Cylinder_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Cylinder_Type
            // 
            resources.ApplyResources(this.lbl_Cylinder_Type, "lbl_Cylinder_Type");
            this.lbl_Cylinder_Type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cylinder_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Cylinder_Type.Name = "lbl_Cylinder_Type";
            // 
            // lbl_Stock_Details
            // 
            resources.ApplyResources(this.lbl_Stock_Details, "lbl_Stock_Details");
            this.lbl_Stock_Details.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Details.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            // 
            // lbl_Stock
            // 
            resources.ApplyResources(this.lbl_Stock, "lbl_Stock");
            this.lbl_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stock.Name = "lbl_Stock";
            // 
            // lbl_Current_Stock
            // 
            resources.ApplyResources(this.lbl_Current_Stock, "lbl_Current_Stock");
            this.lbl_Current_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Current_Stock.ForeColor = System.Drawing.Color.Black;
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            // 
            // lbl_Date
            // 
            resources.ApplyResources(this.lbl_Date, "lbl_Date");
            this.lbl_Date.BackColor = System.Drawing.Color.White;
            this.lbl_Date.Name = "lbl_Date";
            // 
            // dtp_Date_of_Entries
            // 
            resources.ApplyResources(this.dtp_Date_of_Entries, "dtp_Date_of_Entries");
            this.dtp_Date_of_Entries.Name = "dtp_Date_of_Entries";
            // 
            // tb_Stock
            // 
            resources.ApplyResources(this.tb_Stock, "tb_Stock");
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Current_Stock
            // 
            resources.ApplyResources(this.tb_Current_Stock, "tb_Current_Stock");
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_Cylinder_Type
            // 
            this.cmb_Cylinder_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmb_Cylinder_Type, "cmb_Cylinder_Type");
            this.cmb_Cylinder_Type.FormattingEnabled = true;
            this.cmb_Cylinder_Type.Items.AddRange(new object[] {
            resources.GetString("cmb_Cylinder_Type.Items"),
            resources.GetString("cmb_Cylinder_Type.Items1")});
            this.cmb_Cylinder_Type.Name = "cmb_Cylinder_Type";
            this.cmb_Cylinder_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Cylinder_Type_SelectedIndexChanged);
            // 
            // lbl_Stock_ID
            // 
            resources.ApplyResources(this.lbl_Stock_ID, "lbl_Stock_ID");
            this.lbl_Stock_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stock_ID.Name = "lbl_Stock_ID";
            // 
            // tb_Stock_ID
            // 
            resources.ApplyResources(this.tb_Stock_ID, "tb_Stock_ID");
            this.tb_Stock_ID.Name = "tb_Stock_ID";
            this.tb_Stock_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Stock_Details.Controls.Add(this.lbl_Stock_ID);
            this.gb_Stock_Details.Controls.Add(this.lbl_Cylinder_Type);
            this.gb_Stock_Details.Controls.Add(this.tb_Current_Stock);
            this.gb_Stock_Details.Controls.Add(this.tb_Stock_ID);
            this.gb_Stock_Details.Controls.Add(this.lbl_Stock);
            this.gb_Stock_Details.Controls.Add(this.lbl_Current_Stock);
            this.gb_Stock_Details.Controls.Add(this.cmb_Cylinder_Type);
            this.gb_Stock_Details.Controls.Add(this.tb_Stock);
            resources.ApplyResources(this.gb_Stock_Details, "gb_Stock_Details");
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.TabStop = false;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_Hide, "btn_Hide");
            this.btn_Hide.ForeColor = System.Drawing.Color.Black;
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // gb_Stock
            // 
            this.gb_Stock.BackColor = System.Drawing.Color.Silver;
            this.gb_Stock.Controls.Add(this.groupBox2);
            this.gb_Stock.Controls.Add(this.tb_Cylinder_Type);
            this.gb_Stock.Controls.Add(this.gb_Stock_Details);
            this.gb_Stock.Controls.Add(this.btn_Save);
            this.gb_Stock.Controls.Add(this.dtp_Date_of_Entries);
            this.gb_Stock.Controls.Add(this.lbl_Date);
            resources.ApplyResources(this.gb_Stock, "gb_Stock");
            this.gb_Stock.Name = "gb_Stock";
            this.gb_Stock.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_Available_Stock);
            this.groupBox2.Controls.Add(this.lbl_Sale_Stock);
            this.groupBox2.Controls.Add(this.lbl_Availabl_Stock);
            this.groupBox2.Controls.Add(this.tb_Sale_Stock);
            this.groupBox2.Controls.Add(this.cmb_Cylinder);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // tb_Available_Stock
            // 
            resources.ApplyResources(this.tb_Available_Stock, "tb_Available_Stock");
            this.tb_Available_Stock.Name = "tb_Available_Stock";
            // 
            // lbl_Sale_Stock
            // 
            resources.ApplyResources(this.lbl_Sale_Stock, "lbl_Sale_Stock");
            this.lbl_Sale_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sale_Stock.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sale_Stock.Name = "lbl_Sale_Stock";
            // 
            // lbl_Availabl_Stock
            // 
            resources.ApplyResources(this.lbl_Availabl_Stock, "lbl_Availabl_Stock");
            this.lbl_Availabl_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Availabl_Stock.ForeColor = System.Drawing.Color.Black;
            this.lbl_Availabl_Stock.Name = "lbl_Availabl_Stock";
            // 
            // tb_Sale_Stock
            // 
            resources.ApplyResources(this.tb_Sale_Stock, "tb_Sale_Stock");
            this.tb_Sale_Stock.Name = "tb_Sale_Stock";
            // 
            // cmb_Cylinder
            // 
            this.cmb_Cylinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmb_Cylinder, "cmb_Cylinder");
            this.cmb_Cylinder.FormattingEnabled = true;
            this.cmb_Cylinder.Items.AddRange(new object[] {
            resources.GetString("cmb_Cylinder.Items"),
            resources.GetString("cmb_Cylinder.Items1")});
            this.cmb_Cylinder.Name = "cmb_Cylinder";
            this.cmb_Cylinder.SelectedIndexChanged += new System.EventHandler(this.cmb_Cylinder_SelectedIndexChanged);
            // 
            // tb_Cylinder_Type
            // 
            this.tb_Cylinder_Type.BackColor = System.Drawing.Color.DarkBlue;
            this.tb_Cylinder_Type.Controls.Add(this.lbl_Stock_Details);
            this.tb_Cylinder_Type.Controls.Add(this.btn_Hide);
            resources.ApplyResources(this.tb_Cylinder_Type, "tb_Cylinder_Type");
            this.tb_Cylinder_Type.Name = "tb_Cylinder_Type";
            // 
            // frm_Stock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.gb_Stock);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Stock";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Stock_Load);
            this.gb_Stock_Details.ResumeLayout(false);
            this.gb_Stock_Details.PerformLayout();
            this.gb_Stock.ResumeLayout(false);
            this.gb_Stock.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tb_Cylinder_Type.ResumeLayout(false);
            this.tb_Cylinder_Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cylinder_Type;
        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Current_Stock;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date_of_Entries;
        private System.Windows.Forms.TextBox tb_Stock;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Cylinder_Type;
        private System.Windows.Forms.Label lbl_Stock_ID;
        private System.Windows.Forms.TextBox tb_Stock_ID;
        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.GroupBox gb_Stock;
        private System.Windows.Forms.Panel tb_Cylinder_Type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Available_Stock;
        private System.Windows.Forms.Label lbl_Sale_Stock;
        private System.Windows.Forms.Label lbl_Availabl_Stock;
        private System.Windows.Forms.ComboBox cmb_Cylinder;
        private System.Windows.Forms.TextBox tb_Sale_Stock;
    }
}