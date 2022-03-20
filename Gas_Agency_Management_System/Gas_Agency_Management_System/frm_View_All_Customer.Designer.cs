namespace Gas_Agency_Management_System
{
    partial class frm_View_All_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_View_Customer = new System.Windows.Forms.DataGridView();
            this.lbl_View_All_Customer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Hide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Customer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_View_Customer
            // 
            this.dgv_View_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_View_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Customer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Customer.Location = new System.Drawing.Point(0, 194);
            this.dgv_View_Customer.Name = "dgv_View_Customer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Customer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_View_Customer.RowTemplate.Height = 28;
            this.dgv_View_Customer.Size = new System.Drawing.Size(1679, 758);
            this.dgv_View_Customer.TabIndex = 0;
            // 
            // lbl_View_All_Customer
            // 
            this.lbl_View_All_Customer.AutoSize = true;
            this.lbl_View_All_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_All_Customer.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_View_All_Customer.Location = new System.Drawing.Point(521, 34);
            this.lbl_View_All_Customer.Name = "lbl_View_All_Customer";
            this.lbl_View_All_Customer.Size = new System.Drawing.Size(597, 77);
            this.lbl_View_All_Customer.TabIndex = 1;
            this.lbl_View_All_Customer.Text = "View All Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btn_Hide);
            this.panel1.Controls.Add(this.lbl_View_All_Customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1713, 136);
            this.panel1.TabIndex = 16;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.Location = new System.Drawing.Point(1501, 12);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(88, 55);
            this.btn_Hide.TabIndex = 17;
            this.btn_Hide.Text = "X";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // frm_View_All_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 983);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_View_Customer);
            this.Name = "frm_View_All_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_View_All_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Customer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_Customer;
        private System.Windows.Forms.Label lbl_View_All_Customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Hide;
    }
}