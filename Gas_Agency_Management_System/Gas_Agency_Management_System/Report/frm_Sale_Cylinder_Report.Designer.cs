namespace Gas_Agency_Management_System.Report
{
    partial class frm_Sale_Cylinder_Report
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
            this.rpt_Sale_Cylinder_Stock_Report_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_Sale_Cylinder_Stock_Report = new System.Windows.Forms.Label();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpt_Sale_Cylinder_Stock_Report_Viewer
            // 
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.ActiveViewIndex = -1;
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.Location = new System.Drawing.Point(-1, 91);
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.Name = "rpt_Sale_Cylinder_Stock_Report_Viewer";
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.Size = new System.Drawing.Size(1612, 956);
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.TabIndex = 11;
            this.rpt_Sale_Cylinder_Stock_Report_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_Sale_Cylinder_Stock_Report
            // 
            this.lbl_Sale_Cylinder_Stock_Report.AutoSize = true;
            this.lbl_Sale_Cylinder_Stock_Report.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale_Cylinder_Stock_Report.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Sale_Cylinder_Stock_Report.Location = new System.Drawing.Point(491, 4);
            this.lbl_Sale_Cylinder_Stock_Report.Name = "lbl_Sale_Cylinder_Stock_Report";
            this.lbl_Sale_Cylinder_Stock_Report.Size = new System.Drawing.Size(666, 69);
            this.lbl_Sale_Cylinder_Stock_Report.TabIndex = 10;
            this.lbl_Sale_Cylinder_Stock_Report.Text = "Sale Cylinder Stock Report";
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Red;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.ForeColor = System.Drawing.Color.White;
            this.btn_Hide.Location = new System.Drawing.Point(1525, 4);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(73, 54);
            this.btn_Hide.TabIndex = 12;
            this.btn_Hide.Text = "X";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // frm_Sale_Cylinder_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1050);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.rpt_Sale_Cylinder_Stock_Report_Viewer);
            this.Controls.Add(this.lbl_Sale_Cylinder_Stock_Report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Sale_Cylinder_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Sale_Cylinder_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Sale_Cylinder_Stock_Report_Viewer;
        private System.Windows.Forms.Label lbl_Sale_Cylinder_Stock_Report;
        private System.Windows.Forms.Button btn_Hide;
    }
}