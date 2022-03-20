namespace Gas_Agency_Management_System.Report
{
    partial class frm_Customer_Payment_Report
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
            this.lbl_Customer_Payment_Report = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.rpt_Customer_Payment_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Customer_Payment_Report
            // 
            this.lbl_Customer_Payment_Report.AutoSize = true;
            this.lbl_Customer_Payment_Report.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Payment_Report.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Customer_Payment_Report.Location = new System.Drawing.Point(-3, -9);
            this.lbl_Customer_Payment_Report.Name = "lbl_Customer_Payment_Report";
            this.lbl_Customer_Payment_Report.Size = new System.Drawing.Size(654, 69);
            this.lbl_Customer_Payment_Report.TabIndex = 7;
            this.lbl_Customer_Payment_Report.Text = "Customer Payment Report";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(894, 19);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(246, 44);
            this.tb_Customer_ID.TabIndex = 6;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(657, 22);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(201, 37);
            this.lbl_Customer_ID.TabIndex = 5;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(1197, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(175, 50);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // rpt_Customer_Payment_Report
            // 
            this.rpt_Customer_Payment_Report.ActiveViewIndex = -1;
            this.rpt_Customer_Payment_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Customer_Payment_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Customer_Payment_Report.Location = new System.Drawing.Point(30, 69);
            this.rpt_Customer_Payment_Report.Name = "rpt_Customer_Payment_Report";
            this.rpt_Customer_Payment_Report.Size = new System.Drawing.Size(1621, 980);
            this.rpt_Customer_Payment_Report.TabIndex = 8;
            this.rpt_Customer_Payment_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.ForeColor = System.Drawing.Color.White;
            this.btn_Hide.Location = new System.Drawing.Point(1615, 5);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(73, 54);
            this.btn_Hide.TabIndex = 9;
            this.btn_Hide.Text = "X";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // frm_Customer_Payment_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 1050);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.rpt_Customer_Payment_Report);
            this.Controls.Add(this.lbl_Customer_Payment_Report);
            this.Controls.Add(this.tb_Customer_ID);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer_Payment_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Customer_Payment_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Customer_Payment_Report;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Button btn_Search;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Customer_Payment_Report;
        private System.Windows.Forms.Button btn_Hide;
    }
}