using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gas_Agency_Management_System.Report;

namespace Gas_Agency_Management_System
{
    public partial class frm_Payments : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Payments()
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
            
            tb_Connection_Charges.Text = "0";
            tb_Cylinder_Charges.Text = "0";            
            tb_Regulator_Charges.Text = "0";
            cmb_Stove_Type.SelectedIndex = -1;
            tb_Stove_Charges.Text = "0";
            tb_Stand_Charges.Text = "0";
            tb_Total.Text = "0";
            tb_Final_Bill.Text = "0";

            rb_Stand_Yes.Checked = false;
            rb_Stove_Yes.Checked = false;
            rb_Regulator_Yes.Checked = false;

            rb_Stove_No.Checked = true;
            rb_Stand_No.Checked = true;
            rb_Regulator_No.Checked = true;
        }

        private void frm_Payments_Load(object sender, EventArgs e)
        {
            Con_Open();

            Clear_Controls();

            tb_Customer_ID.Text = Convert.ToString(Global_Vars.Customer_ID);

            SqlCommand Cmd1 = new SqlCommand("Select No_of_Cylinder from Customer_Details where Customer_ID = " + tb_Customer_ID.Text + "  ", Con);
            int No_of_Cylinder = Convert.ToInt32(Cmd1.ExecuteScalar());

            SqlCommand Cmd2 = new SqlCommand("Select Cylinder_Type from Customer_Details where Customer_ID = " + tb_Customer_ID.Text + "  ", Con);
            Global_Vars.Cylinder_Type = Convert.ToString(Cmd2.ExecuteScalar());

            if (Global_Vars.Cylinder_Type == Global_Vars.Domestic)
            {
                 SqlCommand Cmd3 = new SqlCommand("Select Sale_Price from Cylinder_Details where Cylinder_Type = '" + Global_Vars.Domestic + "' ", Con);
                 Global_Vars.Domestic = Convert.ToString(Cmd3.ExecuteScalar());

                 double Cylinder_Charges = Convert.ToDouble(Global_Vars.Domestic) * Convert.ToDouble(No_of_Cylinder);
                 tb_Cylinder_Charges.Text = Convert.ToString(Cylinder_Charges);
            }
            else if (Global_Vars.Cylinder_Type == Global_Vars.Commercial)
            {
                 SqlCommand Cmd4 = new SqlCommand("Select Sale_Price from Cylinder_Details where Cylinder_Type = '" + Global_Vars.Commercial + "'  ", Con);
                 Global_Vars.Commercial = Convert.ToString(Cmd4.ExecuteScalar());

                 double Cylinder_Charges = Convert.ToDouble(Global_Vars.Commercial) * Convert.ToDouble(No_of_Cylinder);

                 tb_Cylinder_Charges.Text = Convert.ToString(Cylinder_Charges);
            }

             Cmd1.Dispose();

             Con_Close();
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Stove = ""; 

            if (rb_Stove_Yes.Checked == true)
            {
                Stove = rb_Stove_Yes.Text;
            }
            else
            {
                Stove = rb_Stove_No.Text;
            }

            string Regulator = "";

            if (rb_Regulator_Yes.Checked == true)
            {
                Regulator = rb_Regulator_Yes.Text;
            }
            else
            {
                Regulator = rb_Regulator_No.Text;
            }

            string Stand = "";

            if (rb_Stand_Yes.Checked == true)
            {
                Stand = rb_Stand_Yes.Text;
            }
            else
            {
                Stand = rb_Stand_No.Text;
            }

            if (tb_Customer_ID.Text != "" && tb_Connection_Charges.Text != "" && tb_Cylinder_Charges.Text != "" && tb_Total.Text != "" && tb_GST.Text != "" && tb_Final_Bill.Text != "" && Global_Vars.Uname != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Payment_Details(Customer_ID,Connection_Charges,Cylinder_Charges,Regulator,Regulator_Charges,Stove,Stove_Type,Stove_Charges,Stand,Stand_Charges,Total,GST,Final_Bill,User_Name) values(@Cust_ID,@Conn_Charges,@Cylinder_Charges,'" + Regulator + "',@Regulator_Charges,'" + Stove + "',@Stove_Type,@Stove_Charges,'" + Stand + "',@Stand_Charges,@Total,@GST,@Final_Bill,@User_Name)";
                Cmd.Parameters.Add("@Cust_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("@Conn_Charges", SqlDbType.Money).Value = tb_Connection_Charges.Text;
                Cmd.Parameters.Add("@Cylinder_Charges", SqlDbType.Money).Value = tb_Cylinder_Charges.Text;

                if (tb_Regulator_Charges.Text != "")
                {
                    Cmd.Parameters.Add("@Regulator_Charges", SqlDbType.Money).Value = tb_Regulator_Charges.Text;
                }
               else
                {
                    Cmd.Parameters.Add("@Regulator_Charges", SqlDbType.Money).Value = 0;
                }

                if (cmb_Stove_Type.Text != "")
                {
                    Cmd.Parameters.Add("@Stove_Type", SqlDbType.VarChar).Value = cmb_Stove_Type.Text;
                }
                else
                {
                    Cmd.Parameters.Add("@Stove_Type", SqlDbType.VarChar).Value = 0;
                }

                if (tb_Stove_Charges.Text != "")
                {
                    Cmd.Parameters.Add("@Stove_Charges", SqlDbType.Money).Value = tb_Stove_Charges.Text;
                }
                else
                {
                    Cmd.Parameters.Add("@Stove_Charges", SqlDbType.Money).Value = 0;
                }

                if (tb_Stand_Charges.Text != "")
                {
                    Cmd.Parameters.Add("@Stand_Charges", SqlDbType.Money).Value = tb_Stand_Charges.Text;
                }
                else
                {
                    Cmd.Parameters.Add("@Stand_Charges", SqlDbType.Money).Value = 0;
                }

                Cmd.Parameters.Add("@Total", SqlDbType.Money).Value = tb_Total.Text;
                Cmd.Parameters.Add("@GST", SqlDbType.Int).Value = tb_GST.Text;
                Cmd.Parameters.Add("@Final_Bill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                Cmd.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = Global_Vars.Uname;
            
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Customer_Payment_Report obj = new frm_Customer_Payment_Report();
                obj.TopLevel = false;
                obj.Parent = this;
                obj.Show();

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill All the Fields!!!");
            }

            Con_Close();
        }

        private void btn_Hide_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Stov_Yes_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Stove_Yes.Checked == true)
            {
                tb_Stove_Charges.Enabled = true;
                cmb_Stove_Type.Enabled = true;
            }
        }

        private void Stove_No_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Stove_No.Checked == true)
            {
                tb_Stove_Charges.Enabled = false;
                cmb_Stove_Type.Enabled = false;
            }
        }

        private void rb_Regulator_Yes_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Regulator_Yes.Checked == true)
            {
                tb_Regulator_Charges.Enabled = true;
            }
        }

        private void rb_Regulator_No_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Regulator_No.Checked == true)
            {
                tb_Regulator_Charges.Enabled = false;
            }
        }

        private void rb_Stand_Yes_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Stand_Yes.Checked == true)
            {
                tb_Stand_Charges.Enabled = true;
            }
        }

        private void rb_Stand_No_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Stove_No.Checked == true)
            {
                tb_Stand_Charges.Enabled = false;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }

        }

        private void tb_Stove_Charges_Leave(object sender, EventArgs e)
        {
            if (tb_Stove_Charges.Text == "")
            {
                MessageBox.Show("You Have to fill Stove Charges!!");
                tb_Stove_Charges.Text = "0";
                tb_Stove_Charges.Focus();

            }

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(tb_Cylinder_Charges.Text) + Convert.ToDouble(tb_Connection_Charges.Text) + Convert.ToDouble(tb_Stove_Charges.Text) + Convert.ToDouble(tb_Regulator_Charges.Text) + Convert.ToDouble(tb_Stand_Charges.Text);
            tb_Total.Text = Convert.ToString(total);

            tb_GST.Enabled = true;
            tb_GST.Focus();
        }

        private void tb_Regulator_Charges_Leave(object sender, EventArgs e)
        {
            if (tb_Regulator_Charges.Text == "")
            {
                MessageBox.Show("You Have to fill Regulator Charges!!");
                tb_Regulator_Charges.Text = "0";
                tb_Regulator_Charges.Focus();

            }
        }

        private void tb_Stand_Charges_Leave(object sender, EventArgs e)
        {
            if (tb_Stand_Charges.Text == "")
            {
                MessageBox.Show("You Have to Fill Stand Charges!!");
                tb_Stand_Charges.Text = "0";
                tb_Stand_Charges.Focus();

            }
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            double Final_Bill = (Convert.ToDouble(tb_Total.Text) + (Convert.ToDouble(tb_Total.Text) * Convert.ToDouble(tb_GST.Text) /100));
            
            tb_Final_Bill.Text = Convert.ToString(Final_Bill);
            //tb_GST.Enabled = false;

        }
    }
}
