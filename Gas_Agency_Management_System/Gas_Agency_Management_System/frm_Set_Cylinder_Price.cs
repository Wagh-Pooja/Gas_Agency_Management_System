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
    public partial class frm_Set_Cylinder_Price : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Set_Cylinder_Price()
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
        void Clear_Controls()
        {
            rb_Domestic.Checked = false;
            rb_Commercial.Checked = false;
            tb_Sale_Price.Text = "";
            tb_Purchase_Price.Text = "";
        }

        private void frm_Set_Cylinder_Price_Load(object sender, EventArgs e)
        {
            gb_Cylinder_Type.Focus();
        }

        private void Cylinder_Type_Checked_Change(object sender, EventArgs e)
        {

        }

        private void Is_Price(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            string Cylinder_Type = "";

            if (rb_Domestic.Checked == true)
            {
                Cylinder_Type = rb_Domestic.Text;
            }
            else
            {
                Cylinder_Type = rb_Commercial.Text;
            }

            if (tb_Sale_Price.Text != "" && tb_Purchase_Price.Text != "" && Global_Vars.Uname != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Cylinder_Details Set Sale_Price = " + tb_Sale_Price.Text + ", Purchase_Price = " + tb_Purchase_Price.Text + " where Cylinder_Type = '" + Cylinder_Type + "' ", Con);
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Set Cylinder Price Successfully!!!");
            }
            else
            {
                MessageBox.Show("First Fill All The Fields");
            }
            Clear_Controls();

            Con_Close();
           
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
