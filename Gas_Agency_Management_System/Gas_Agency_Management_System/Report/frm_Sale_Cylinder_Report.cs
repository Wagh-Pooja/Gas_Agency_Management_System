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
    public partial class frm_Sale_Cylinder_Report : Form
    {
        crpt_Sale_Cylinder_Report crpt = new crpt_Sale_Cylinder_Report();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");


        public frm_Sale_Cylinder_Report()
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

        private void frm_Sale_Cylinder_Report_Load(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Sale_Stock ", Con);
            sda.Fill(ds, "Sale_Stock");
            crpt.Load(@"E:\C#.net Project\Gas_Agency_Management_System\Gas_Agency_Management_System\Report\crpt_Sale_Cylinder_Report.rpt");
            crpt.SetDataSource(ds);
            rpt_Sale_Cylinder_Stock_Report_Viewer.ReportSource = crpt;

            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
