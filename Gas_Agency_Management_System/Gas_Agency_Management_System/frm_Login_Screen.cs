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
    public partial class frm_Login_Screen : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Login_Screen()
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

        private void frm_Login_Screen_Load(object sender, EventArgs e)
        {
          //  tb_Username.Focus();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Count(*) from User_Login where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "' ", Con);

            if (Convert.ToInt32(Cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successful!!!");
                Global_Vars.Uname = "Welcome " + tb_Username.Text;


                if (tb_Username.Text == "Admin")
                {
                    Global_Vars.URole = 1;
                }
                else if (tb_Username.Text == "a")
                {
                    Global_Vars.URole = 2;
                }
                frm_Gas_Agency_Management_System obj = new frm_Gas_Agency_Management_System();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Your Valid Username And Password !!!");
            }

            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus(); 

            Con_Close();
     
        }

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            tb_Username.Text = "";
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            tb_Password.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
