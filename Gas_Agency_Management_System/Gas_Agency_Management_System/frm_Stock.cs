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
    public partial class frm_Stock : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Stock()
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

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = " Select Count(Stock_ID) from Stock_Entries";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cnt = Cnt + 101;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();
            return Cnt;

        }
       
        void Clear_Controls()
        {
            tb_Stock_ID.Text = Convert.ToString(Auto_Incr());
            cmb_Cylinder_Type.SelectedIndex = -1;
            tb_Stock.Text = "";
            tb_Current_Stock.Text = "";

        }

        private void frm_Stock_Load(object sender, EventArgs e)
        {
            tb_Stock_ID.Focus();

            Clear_Controls();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                Con_Open();
                if (tb_Stock_ID.Text != "" && cmb_Cylinder_Type.Text != "" && dtp_Date_of_Entries.Text != "" && tb_Stock.Text != "" && tb_Current_Stock.Text != "" && Global_Vars.Uname != "")
                {
                    SqlCommand Cmd1 = new SqlCommand("Insert into Stock_Entries Values(" + tb_Stock_ID.Text + ", '" + cmb_Cylinder_Type.Text + "', '" + dtp_Date_of_Entries.Text + "', " + tb_Stock.Text + ", '" + Global_Vars.Uname + "')", Con);

                    int Stock = 0;

                    Stock = Convert.ToInt32(tb_Stock.Text) + Convert.ToInt32(tb_Current_Stock.Text);

                    SqlCommand Cmd2 = new SqlCommand("Update Cylinder_Details Set Current_Stock = " + Stock + " Where Cylinder_Type = '" + cmb_Cylinder_Type.Text + "' ", Con);

                    Cmd1.ExecuteNonQuery();
                    Cmd2.ExecuteNonQuery();

                    MessageBox.Show("Stock Added Successfully!!");
                    Clear_Controls();
                }

                else if (cmb_Cylinder.Text != "" && tb_Sale_Stock.Text != "" && tb_Available_Stock.Text != "" && dtp_Date_of_Entries.Text != "")
                {
                    SqlCommand Cmd3 = new SqlCommand("Insert into Sale_Stock values('" + cmb_Cylinder.Text + "'," + tb_Sale_Stock.Text + "," + tb_Available_Stock.Text + ",'" + dtp_Date_of_Entries.Text + "')", Con);
                    Cmd3.ExecuteNonQuery();

                    MessageBox.Show("Record Save successfully!!");
                    cmb_Cylinder.Text = "";
                    tb_Sale_Stock.Text = "";
                    tb_Available_Stock.Text = "";

                }
                else
                {
                    MessageBox.Show("First Fill All The Fields");
                }

                Con_Close();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
                
            }                
            
        }

        private void cmb_Cylinder_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Current_Stock from Cylinder_Details where Cylinder_Type = '" + cmb_Cylinder_Type.Text + "' ", Con);
            tb_Current_Stock.Text = Convert.ToString(Cmd.ExecuteScalar());
            
            Con_Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmb_Cylinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd5 = new SqlCommand("Select Count(*) from Booking_Details where Booking_Date = '" + dtp_Date_of_Entries.Text + "' And Cylinder_Type = '" + cmb_Cylinder.Text + "'  ", Con);
            tb_Sale_Stock.Text = Convert.ToString(Cmd5.ExecuteScalar());

            SqlCommand Cmd4 = new SqlCommand("Select Current_Stock from Cylinder_Details where Cylinder_Type =  '" + cmb_Cylinder.Text + "'  ", Con);
            double Available_Stock = Convert.ToDouble(Cmd4.ExecuteScalar());

            double Total_Stock =  Convert.ToDouble(Available_Stock) - Convert.ToDouble(tb_Sale_Stock.Text);

            tb_Available_Stock.Text = Convert.ToString(Total_Stock);
           
            Con_Close();
        }
    }
}