namespace Gas_Agency_Management_System
{
    partial class frm_View_Sale_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.lbl_View_Sale_Stock = new System.Windows.Forms.Label();
            this.pnl_Heading = new System.Windows.Forms.Panel();
            this.dgv_View_Sale_Stock = new System.Windows.Forms.DataGridView();
            this.pnl_Heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Sale_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Hide.ForeColor = System.Drawing.Color.Black;
            this.btn_Hide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Hide.Location = new System.Drawing.Point(1546, 12);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(79, 46);
            this.btn_Hide.TabIndex = 7;
            this.btn_Hide.Text = "X";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // lbl_View_Sale_Stock
            // 
            this.lbl_View_Sale_Stock.AutoSize = true;
            this.lbl_View_Sale_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_Sale_Stock.Font = new System.Drawing.Font("Modern No. 20", 47F);
            this.lbl_View_Sale_Stock.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_View_Sale_Stock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_View_Sale_Stock.Location = new System.Drawing.Point(459, 35);
            this.lbl_View_Sale_Stock.Name = "lbl_View_Sale_Stock";
            this.lbl_View_Sale_Stock.Size = new System.Drawing.Size(648, 97);
            this.lbl_View_Sale_Stock.TabIndex = 6;
            this.lbl_View_Sale_Stock.Text = "View Sale Stock";
            // 
            // pnl_Heading
            // 
            this.pnl_Heading.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_Heading.Controls.Add(this.lbl_View_Sale_Stock);
            this.pnl_Heading.Controls.Add(this.btn_Hide);
            this.pnl_Heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Heading.Location = new System.Drawing.Point(0, 0);
            this.pnl_Heading.Name = "pnl_Heading";
            this.pnl_Heading.Size = new System.Drawing.Size(1648, 152);
            this.pnl_Heading.TabIndex = 8;
            // 
            // dgv_View_Sale_Stock
            // 
            this.dgv_View_Sale_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_Sale_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Sale_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Sale_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Sale_Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Sale_Stock.Location = new System.Drawing.Point(33, 230);
            this.dgv_View_Sale_Stock.Name = "dgv_View_Sale_Stock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Sale_Stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_View_Sale_Stock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_View_Sale_Stock.RowTemplate.Height = 28;
            this.dgv_View_Sale_Stock.Size = new System.Drawing.Size(1539, 510);
            this.dgv_View_Sale_Stock.TabIndex = 9;
            // 
            // frm_View_Sale_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 870);
            this.Controls.Add(this.dgv_View_Sale_Stock);
            this.Controls.Add(this.pnl_Heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_Sale_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sale Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Cylinder_Status_Load);
            this.pnl_Heading.ResumeLayout(false);
            this.pnl_Heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Sale_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Label lbl_View_Sale_Stock;
        private System.Windows.Forms.Panel pnl_Heading;
        private System.Windows.Forms.DataGridView dgv_View_Sale_Stock;

    }
}