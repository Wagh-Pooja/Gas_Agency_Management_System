using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gas_Agency_Management_System.Report
{
    public partial class frm_Customer_Complaint_Report : Form
    {
        crpt_Customer_Complaint_Report crpt = new crpt_Customer_Complaint_Report();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Customer_Complaint_Report()
        {
            InitializeComponent();
        }

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Customer_Complaint_Report_Load(object sender, EventArgs e)
        {
            tb_Complaint_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select Complaint_ID,Customer_ID,Customer_Name,Mobile_No,Area,Complaint,Complaint_Date from Complaint_Details where Complaint_ID  = " + tb_Complaint_ID.Text + "  ", Con);
            sda.Fill(ds, "Complaint_Details");
            crpt.Load(@"E:\C#.net Project\Gas_Agency_Management_System\Gas_Agency_Management_System\Report\crpt_Customer_Complaint_Report.rpt");
            crpt.SetDataSource(ds);
            rpt_Customer_Complaint_Report.ReportSource = crpt;
            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
