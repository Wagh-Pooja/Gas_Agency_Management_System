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
    public partial class frm_Complaint : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Complaint()
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
            Cmd.CommandText = " Select Count(Complaint_ID) from Complaint_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            Cnt = Cnt + 101;

            Con_Close();
            return Cnt;

        }

        void Clear_Controls()
        {
            tb_Customer_ID.Text = "";           
            tb_Customer_Name.Text = "";
            tb_Mobile_No.Text = "";
            tb_Area.Text = "";
            tb_Complaint.Text = "";
        }

        private void frm_Complaint_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Focus();
            tb_Complaint_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
                Con_Open();
                SqlCommand Cmd2 = new SqlCommand("Select First_Name,Middle_Name,Last_Name,Area,Mobile_No from Customer_Details where Customer_ID = " + tb_Customer_ID.Text + " ", Con);
                var obj = Cmd2.ExecuteReader();

                if (obj.Read())
                {
                    tb_Customer_Name.Text = obj.GetString(obj.GetOrdinal("First_Name")) + " "  + obj.GetString(obj.GetOrdinal("Middle_Name"))+ " " + obj.GetString(obj.GetOrdinal("Last_Name"));
                    tb_Area.Text = obj.GetString(obj.GetOrdinal("Area"));
                    tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID !!");
                }

                Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Complaint_ID.Text != "" && tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Area.Text != "" && tb_Complaint.Text != "" && dtp_Complaint_Date.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Complaint_Details(Complaint_ID,Customer_ID,Customer_Name,Mobile_No,Area,Complaint,Complaint_Date) values(@Complt_ID,@Cust_ID,@Cust_Name,@Mob_No,@Area,@Complaint,@Complt_Date)";
                Cmd.Parameters.Add("@Complt_ID", SqlDbType.Int).Value = tb_Complaint_ID.Text;
                Cmd.Parameters.Add("@Cust_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("@Cust_Name", SqlDbType.VarChar).Value = tb_Customer_Name.Text;              
                Cmd.Parameters.Add("@Mob_No", SqlDbType.BigInt).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@Area", SqlDbType.VarChar).Value = tb_Area.Text;
                Cmd.Parameters.Add("@Complaint", SqlDbType.VarChar).Value = tb_Complaint.Text;
                Cmd.Parameters.Add("@Complt_Date", SqlDbType.Date).Value = dtp_Complaint_Date.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully!!!");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All the fields!!!");
            }

            Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
