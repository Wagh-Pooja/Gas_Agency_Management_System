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
    public partial class frm_Add_New_Booking : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Add_New_Booking()
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
            Cmd.CommandText = " Select Count(Booking_ID) from Booking_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            Cnt = Cnt + 101;

            Con_Close();
            return Cnt;

        }

        void Clear_Controls()
        {          
            tb_Customer_Name.Text = "";
            tb_Booking_ID.Text = Convert.ToString(Auto_Incr());
            tb_Mobile_No.Text = "";
            tb_Customer_ID.Text = "";
            tb_Area.Text = "";
            cmb_Cylinder_Type.SelectedIndex = -1;
            tb_No_of_Cylinder.Text = "";
            tb_Cylinder_Price.Text = "";
            tb_Payment.Text = "";
            cmb_Delivery_Boy.SelectedIndex = -1;
        }
     
        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frm_Add_New_Booking_Load(object sender, EventArgs e)
        {
            rb_Mob_No.Focus();  
            tb_Booking_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (rb_Mob_No.Checked == true)
            {
                SqlCommand Cmd1 = new SqlCommand("Select Customer_ID,First_Name,Middle_Name,Last_Name,Area,Cylinder_Type,No_of_Cylinder from Customer_Details where Mobile_No = " + tb_Mobile_No.Text + " ", Con);
                var obj = Cmd1.ExecuteReader();

                if (obj.Read())
                {
                    tb_Customer_Name.Text = obj.GetString(obj.GetOrdinal("First_Name")) + " " + obj.GetString(obj.GetOrdinal("Middle_Name")) + " " + obj.GetString(obj.GetOrdinal("Last_Name"));
                    tb_Customer_ID.Text = (obj["Customer_ID"].ToString());
                    tb_Area.Text = obj.GetString(obj.GetOrdinal("Area"));
                    cmb_Cylinder_Type.Text = obj.GetString(obj.GetOrdinal("Cylinder_Type"));
                    tb_No_of_Cylinder.Text = (obj["No_of_Cylinder"].ToString());

                    obj.Close();
                    Cmd1.Dispose();

                    SqlCommand Cmd2 = new SqlCommand("Select Max(Previous_Booking) from Booking_Details where Mobile_No =  " + tb_Mobile_No.Text + "  ", Con);
                    dtp_Previous_Book.Text = Convert.ToString(Cmd2.ExecuteScalar());
                    Cmd2.Dispose();


                    SqlCommand Cmd = new SqlCommand("Select Sale_Price from Cylinder_Details where Cylinder_Type = '" + cmb_Cylinder_Type.Text + "' ", Con);
                    tb_Cylinder_Price.Text = Convert.ToString(Cmd.ExecuteScalar());

                    double Payment = Convert.ToDouble(tb_Cylinder_Price.Text) + 50;
                    tb_Payment.Text = Convert.ToString(Payment);

                    rb_Customer_ID.Enabled = false; 
                    tb_Mobile_No.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid Mobile NO");
                    tb_Mobile_No.Clear();
                   
                }

            }
            else if (rb_Customer_ID.Checked == true)
            {
                SqlCommand Cmd2 = new SqlCommand("Select First_Name,Middle_Name,Last_Name,Area,Mobile_No,Cylinder_Type,No_of_Cylinder from Customer_Details where Customer_ID = " + tb_Customer_ID.Text + " ", Con);
                var obj = Cmd2.ExecuteReader();

                if (obj.Read())
                {
                    tb_Customer_Name.Text = obj.GetString(obj.GetOrdinal("First_Name")) + "  " + obj.GetString(obj.GetOrdinal("Middle_Name")) + "  " + obj.GetString(obj.GetOrdinal("Last_Name"));
                    tb_Area.Text = obj.GetString(obj.GetOrdinal("Area"));
                    tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                    cmb_Cylinder_Type.Text = obj.GetString(obj.GetOrdinal("Cylinder_Type"));
                    tb_No_of_Cylinder.Text = (obj["No_of_Cylinder"].ToString());

                    obj.Close();
                    Cmd2.Dispose();

                    SqlCommand Cmd3 = new SqlCommand("Select Max(Previous_Booking) from Booking_Details where Customer_ID =  " + tb_Customer_ID.Text + "  ", Con);
                    dtp_Previous_Book.Text = Convert.ToString(Cmd3.ExecuteScalar());
                    Cmd3.Dispose();

                    SqlCommand Cmd = new SqlCommand("Select Sale_Price from Cylinder_Details where Cylinder_Type = '" + cmb_Cylinder_Type.Text + "' ", Con);
                    tb_Cylinder_Price.Text = Convert.ToString(Cmd.ExecuteScalar());

                    double Payment = Convert.ToDouble(tb_Cylinder_Price.Text) + 50;
                    tb_Payment.Text = Convert.ToString(Payment);
           
                    tb_Customer_ID.Enabled = false;
                    rb_Mob_No.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID");
                    tb_Customer_ID.Clear();
                }

            }

            Con_Close();
        }

        private void Mobile_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Mob_No.Checked == true)
            {
                tb_Customer_ID.Enabled = false;
                tb_Mobile_No.Enabled = true;
                tb_Mobile_No.Focus();
            }
        }

        private void Customer_ID_Checked_Change(object sender, EventArgs e)
        {
            if (rb_Customer_ID.Checked == true)
            {
                tb_Mobile_No.Enabled = false;
                tb_Customer_ID.Enabled = true;
                tb_Customer_ID.Focus();
            }
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Booking_ID.Text != "" && tb_Mobile_No.Text != "" && tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && tb_Area.Text != "" && dtp_Booking_Date.Text != "" && tb_No_of_Cylinder.Text != "" && dtp_Previous_Book.Text != "" && tb_Cylinder_Price.Text != "" && tb_Payment.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Booking_Details(Booking_ID,Mobile_No,Customer_ID,Customer_Name,Area,Booking_Date,Cylinder_Type,No_of_Cylinder,Previous_Booking,Cylinder_Price,Payment,Delivery_Boy) values(@Book_ID,@Mob_No,@Cust_ID,@Cust_Name,@Area,@Book_Date,@Cylinder_Type,@No_of_Cylinder,@Previous_Book,@Cylinder_Price,@Payment,@Delivery_BOy)";
                Cmd.Parameters.Add("@Book_ID", SqlDbType.Int).Value = tb_Booking_ID.Text;
                Cmd.Parameters.Add("@Mob_No", SqlDbType.BigInt).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@Cust_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("@Cust_Name", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                Cmd.Parameters.Add("@Area", SqlDbType.VarChar).Value = tb_Area.Text;
                Cmd.Parameters.Add("@Book_Date", SqlDbType.Date).Value = dtp_Booking_Date.Text;
                Cmd.Parameters.Add("@Cylinder_Type", SqlDbType.VarChar).Value = cmb_Cylinder_Type.Text;
                Cmd.Parameters.Add("@No_of_Cylinder", SqlDbType.BigInt).Value = tb_No_of_Cylinder.Text;

                Cmd.Parameters.Add("@Previous_Book", SqlDbType.Date).Value = dtp_Previous_Book.Text;
                
                Cmd.Parameters.Add("@Cylinder_Price", SqlDbType.Money).Value = tb_Cylinder_Price.Text;
                Cmd.Parameters.Add("@Payment", SqlDbType.Money).Value = tb_Payment.Text;
                Cmd.Parameters.Add("@Delivery_Boy", SqlDbType.VarChar).Value = cmb_Delivery_Boy.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully!!!");

                Clear_Controls();

                frm_Customer_Booking_Report obj = new frm_Customer_Booking_Report();
                obj.TopLevel = false;
                obj.Parent = this;
                obj.Show();
            }
            else
            {
                MessageBox.Show("First Fill All the fields!!!");
            }

            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            rb_Customer_ID.Enabled = true;
            rb_Mob_No.Enabled = true;
            tb_Customer_ID.Enabled = true;
            tb_Mobile_No.Enabled = true;
        } 
   
    }
}
  