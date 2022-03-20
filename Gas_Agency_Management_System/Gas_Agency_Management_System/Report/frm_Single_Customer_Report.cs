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
    public partial class frm_Single_Customer_Report : Form
    {
        crpt_Single_Customer_Report crpt = new crpt_Single_Customer_Report();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Single_Customer_Report()
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

        private void frm_Single_Customer_Report_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("Select Date_of_Connection,Customer_ID,First_Name,Middle_Name,Last_Name,Aadhar_No,PAN_Card_No,Address,Area,Mobile_No,Phone_No,Bank_Account_No,Cylinder_Type,No_of_Cylinder from Customer_Details where Customer_ID = " + tb_Customer_ID.Text + "   ", Con);
            sda.Fill(ds, "Customer_Details");
            crpt.SetDataSource(ds);
            rpt_Single_Customer_Report_Viewer.ReportSource = crpt;

            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
