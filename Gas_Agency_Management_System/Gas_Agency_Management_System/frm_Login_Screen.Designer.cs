namespace Gas_Agency_Management_System
{
    partial class frm_Login_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_Screen));
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Signin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Password
            // 
            this.pb_Password.BackColor = System.Drawing.Color.Transparent;
            this.pb_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Password.BackgroundImage")));
            this.pb_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Password.Location = new System.Drawing.Point(96, 229);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(119, 81);
            this.pb_Password.TabIndex = 7;
            this.pb_Password.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 669);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(237, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 167);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_Username);
            this.panel3.Controls.Add(this.pb_Password);
            this.panel3.Controls.Add(this.pb_Username);
            this.panel3.Controls.Add(this.tb_Password);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 366);
            this.panel3.TabIndex = 1;
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Username.ForeColor = System.Drawing.Color.White;
            this.tb_Username.Location = new System.Drawing.Point(209, 57);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(327, 81);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.Text = "Username";
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            // 
            // pb_Username
            // 
            this.pb_Username.BackColor = System.Drawing.Color.Transparent;
            this.pb_Username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Username.BackgroundImage")));
            this.pb_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Username.Location = new System.Drawing.Point(96, 57);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(119, 81);
            this.pb_Username.TabIndex = 6;
            this.pb_Username.TabStop = false;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Password.ForeColor = System.Drawing.Color.White;
            this.tb_Password.Location = new System.Drawing.Point(209, 229);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(327, 81);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "Password";
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.btn_Signin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 133);
            this.panel2.TabIndex = 0;
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.Color.Red;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.ForeColor = System.Drawing.Color.White;
            this.btn_Signin.Location = new System.Drawing.Point(97, 40);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(440, 61);
            this.btn_Signin.TabIndex = 3;
            this.btn_Signin.Text = "Log-in";
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(301, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 675);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gb";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(315, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1245, 1051);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1245, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1742, 1066);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Login_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Signin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}