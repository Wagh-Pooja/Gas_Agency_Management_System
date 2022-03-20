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
    public partial class frm_Customer_Booking_Report : Form
    {
        crpt_Customer_Booking_Report crpt = new crpt_Customer_Booking_Report();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Customer_Booking_Report()
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


        private void frm_Customer_Booking_Report_Load(object sender, EventArgs e)
        {
            tb_Booking_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("Select Booking_ID,Mobile_No,Customer_ID,Customer_Name,Area,Booking_Date,Cylinder_Type,Cylinder_Price,Payment from Booking_Details where Booking_ID = " + tb_Booking_ID.Text + "   ", Con);
            sda.Fill(ds, "Booking_Details");
            crpt.SetDataSource(ds);
            rpt_Customer_Booking_Report_Viewer.ReportSource = crpt;

            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
