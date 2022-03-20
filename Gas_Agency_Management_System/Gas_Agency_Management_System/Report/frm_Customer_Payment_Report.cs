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
    public partial class frm_Customer_Payment_Report : Form
    {
        crpt_Customer_Payment_Report crpt = new crpt_Customer_Payment_Report();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Customer_Payment_Report()
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

        private void frm_Customer_Payment_Report_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select Customer_Details.First_Name, Customer_Details.Middle_Name, Customer_Details.Last_Name, Customer_Details.Address, Customer_Details.Mobile_No , Customer_Details.Cylinder_Type, Customer_Details.No_of_Cylinder, Payment_Details.Customer_ID, Payment_Details.Connection_Charges, Payment_Details.Cylinder_Charges, Payment_Details.Regulator, Payment_Details.Regulator_Charges, Payment_Details.Stove, Payment_Details.Stove_Type, Payment_Details.Stove_Charges, Payment_Details.Stand, Payment_Details.Stand_Charges, Payment_Details.Total, Payment_Details.GST, Payment_Details.Final_Bill, Payment_Details.User_Name FROM Customer_Details INNER JOIN Payment_Details ON Customer_Details.Customer_ID = Payment_Details.Customer_ID Where Customer_Details.Customer_ID = " + tb_Customer_ID.Text + "  ", Con);
            sda.Fill(ds, "Customer_Details");
            sda.Fill(ds, "Payment_Details");
            crpt.Load(@"E:\C#.net Project\Gas_Agency_Management_System\Gas_Agency_Management_System\Report\crpt_Customer_Payment_Report.rpt");
            crpt.SetDataSource(ds);
            rpt_Customer_Payment_Report.ReportSource = crpt;

            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
