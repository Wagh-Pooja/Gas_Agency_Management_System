namespace Gas_Agency_Management_System
{
    partial class frm_Set_Cylinder_Price
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
            this.lbl_Cylinder_Type = new System.Windows.Forms.Label();
            this.lbl_Sale_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Sale_Price = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.gb_Cylinder_Price = new System.Windows.Forms.GroupBox();
            this.gb_Cylinder_Type = new System.Windows.Forms.GroupBox();
            this.rb_Domestic = new System.Windows.Forms.RadioButton();
            this.rb_Commercial = new System.Windows.Forms.RadioButton();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.lbl_Set_Cylinder_Price = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_Heading = new System.Windows.Forms.Panel();
            this.gb_Cylinder_Price.SuspendLayout();
            this.gb_Cylinder_Type.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_Heading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Cylinder_Type
            // 
            this.lbl_Cylinder_Type.AutoSize = true;
            this.lbl_Cylinder_Type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cylinder_Type.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cylinder_Type.Location = new System.Drawing.Point(53, 79);
            this.lbl_Cylinder_Type.Name = "lbl_Cylinder_Type";
            this.lbl_Cylinder_Type.Size = new System.Drawing.Size(230, 36);
            this.lbl_Cylinder_Type.TabIndex = 1;
            this.lbl_Cylinder_Type.Text = "Cylinder Type";
            // 
            // lbl_Sale_Price
            // 
            this.lbl_Sale_Price.AutoSize = true;
            this.lbl_Sale_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sale_Price.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale_Price.Location = new System.Drawing.Point(53, 182);
            this.lbl_Sale_Price.Name = "lbl_Sale_Price";
            this.lbl_Sale_Price.Size = new System.Drawing.Size(163, 36);
            this.lbl_Sale_Price.TabIndex = 2;
            this.lbl_Sale_Price.Text = "Sale Price";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(53, 276);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(243, 36);
            this.lbl_Purchase_Price.TabIndex = 3;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // tb_Sale_Price
            // 
            this.tb_Sale_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sale_Price.Location = new System.Drawing.Point(359, 176);
            this.tb_Sale_Price.Name = "tb_Sale_Price";
            this.tb_Sale_Price.Size = new System.Drawing.Size(379, 44);
            this.tb_Sale_Price.TabIndex = 2;
            this.tb_Sale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(359, 272);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(379, 44);
            this.tb_Purchase_Price.TabIndex = 3;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // gb_Cylinder_Price
            // 
            this.gb_Cylinder_Price.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Cylinder_Price.Controls.Add(this.gb_Cylinder_Type);
            this.gb_Cylinder_Price.Controls.Add(this.lbl_Cylinder_Type);
            this.gb_Cylinder_Price.Controls.Add(this.tb_Purchase_Price);
            this.gb_Cylinder_Price.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Cylinder_Price.Controls.Add(this.tb_Sale_Price);
            this.gb_Cylinder_Price.Controls.Add(this.lbl_Sale_Price);
            this.gb_Cylinder_Price.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Cylinder_Price.Location = new System.Drawing.Point(70, 246);
            this.gb_Cylinder_Price.Name = "gb_Cylinder_Price";
            this.gb_Cylinder_Price.Size = new System.Drawing.Size(777, 385);
            this.gb_Cylinder_Price.TabIndex = 14;
            this.gb_Cylinder_Price.TabStop = false;
            this.gb_Cylinder_Price.Text = "Cylinder Price";
            // 
            // gb_Cylinder_Type
            // 
            this.gb_Cylinder_Type.Controls.Add(this.rb_Domestic);
            this.gb_Cylinder_Type.Controls.Add(this.rb_Commercial);
            this.gb_Cylinder_Type.Location = new System.Drawing.Point(359, 56);
            this.gb_Cylinder_Type.Name = "gb_Cylinder_Type";
            this.gb_Cylinder_Type.Size = new System.Drawing.Size(379, 83);
            this.gb_Cylinder_Type.TabIndex = 1;
            this.gb_Cylinder_Type.TabStop = false;
            // 
            // rb_Domestic
            // 
            this.rb_Domestic.AutoSize = true;
            this.rb_Domestic.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Domestic.Location = new System.Drawing.Point(18, 34);
            this.rb_Domestic.Name = "rb_Domestic";
            this.rb_Domestic.Size = new System.Drawing.Size(142, 34);
            this.rb_Domestic.TabIndex = 38;
            this.rb_Domestic.TabStop = true;
            this.rb_Domestic.Text = "Domestic";
            this.rb_Domestic.UseVisualStyleBackColor = true;
            this.rb_Domestic.CheckedChanged += new System.EventHandler(this.Cylinder_Type_Checked_Change);
            // 
            // rb_Commercial
            // 
            this.rb_Commercial.AutoSize = true;
            this.rb_Commercial.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Commercial.Location = new System.Drawing.Point(191, 34);
            this.rb_Commercial.Name = "rb_Commercial";
            this.rb_Commercial.Size = new System.Drawing.Size(172, 34);
            this.rb_Commercial.TabIndex = 39;
            this.rb_Commercial.TabStop = true;
            this.rb_Commercial.Text = "Commercial";
            this.rb_Commercial.UseVisualStyleBackColor = true;
            this.rb_Commercial.CheckedChanged += new System.EventHandler(this.Cylinder_Type_Checked_Change);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(364, 698);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(192, 65);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.Location = new System.Drawing.Point(827, 12);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(76, 50);
            this.btn_Hide.TabIndex = 8;
            this.btn_Hide.Text = "X";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // lbl_Set_Cylinder_Price
            // 
            this.lbl_Set_Cylinder_Price.AutoSize = true;
            this.lbl_Set_Cylinder_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Set_Cylinder_Price.Font = new System.Drawing.Font("Modern No. 20", 30F);
            this.lbl_Set_Cylinder_Price.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Set_Cylinder_Price.Location = new System.Drawing.Point(223, 53);
            this.lbl_Set_Cylinder_Price.Name = "lbl_Set_Cylinder_Price";
            this.lbl_Set_Cylinder_Price.Size = new System.Drawing.Size(470, 62);
            this.lbl_Set_Cylinder_Price.TabIndex = 7;
            this.lbl_Set_Cylinder_Price.Text = "Set Cylinder Price";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.pnl_Heading);
            this.groupBox1.Controls.Add(this.gb_Cylinder_Price);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Location = new System.Drawing.Point(365, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 801);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pnl_Heading
            // 
            this.pnl_Heading.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_Heading.Controls.Add(this.btn_Hide);
            this.pnl_Heading.Controls.Add(this.lbl_Set_Cylinder_Price);
            this.pnl_Heading.Location = new System.Drawing.Point(3, 0);
            this.pnl_Heading.Name = "pnl_Heading";
            this.pnl_Heading.Size = new System.Drawing.Size(906, 149);
            this.pnl_Heading.TabIndex = 16;
            // 
            // frm_Set_Cylinder_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1596, 898);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Set_Cylinder_Price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Set_Cylinder_Price_Load);
            this.gb_Cylinder_Price.ResumeLayout(false);
            this.gb_Cylinder_Price.PerformLayout();
            this.gb_Cylinder_Type.ResumeLayout(false);
            this.gb_Cylinder_Type.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnl_Heading.ResumeLayout(false);
            this.pnl_Heading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cylinder_Type;
        private System.Windows.Forms.Label lbl_Sale_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Sale_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.GroupBox gb_Cylinder_Price;
        private System.Windows.Forms.RadioButton rb_Commercial;
        private System.Windows.Forms.RadioButton rb_Domestic;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Set_Cylinder_Price;
        private System.Windows.Forms.GroupBox gb_Cylinder_Type;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl_Heading;
    }
}