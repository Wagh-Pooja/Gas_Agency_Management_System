using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gas_Agency_Management_System
{
    public partial class frm_View_Cylinder_Stock : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_View_Cylinder_Stock()
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

        private void frm_View_Cylinder_Stock_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Stock_Entries",Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_View_Cylinder_Stock.DataSource = dt;

            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
