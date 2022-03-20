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
    public partial class frm_Add_New_Customer : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Add_New_Customer()
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
            Cmd.CommandText = " Select Count(Customer_ID) from Customer_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            Cnt = Cnt + 1001;

            Con_Close();
            return Cnt;

        }
        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
            tb_First_Name.Text = "";
            tb_Middle_Name.Text = "";
            tb_Last_Name.Text = "";
            tb_Aadhar_No.Text = "";
            tb_PAN_Card_No.Text = "";
            tb_Address.Text = "";
            tb_Area.Text = "";
            tb_Mobile_No.Text = "";
            tb_Phone_No.Text = "";
            tb_Bank_Account_No.Text = "";
            rb_Commercial.Checked = false;
            rb_Domestic.Checked = false;
            cmb_No_of_Cylinder.Text = "";
            tb_First_Name.Focus();

        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            tb_First_Name.Focus();
            Clear_Controls();
        }

        private void Cylinder_Type_Checked_Change(object sender, EventArgs e)
        {
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
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

                if (dtp_Date_of_Connection.Text != "" && tb_Customer_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Aadhar_No.Text != "" && tb_PAN_Card_No.Text != "" && tb_Address.Text != "" && tb_Area.Text != "" && tb_Mobile_No.Text != "" && tb_Bank_Account_No.Text != "" && cmb_No_of_Cylinder.Text != "" && Global_Vars.Uname != "")
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Insert into Customer_Details(Date_of_Connection,Customer_ID,First_Name,Middle_Name,Last_Name,Aadhar_No,PAN_Card_No,Address,Area,Mobile_No,Phone_No,Bank_Account_No,Cylinder_Type,No_of_Cylinder,User_Name) values(@cstDate, @cstCust_ID, @cstF_Name, @cstM_Name, @cstL_Name, @cstAadhar_No, @cstPAN_No, @cstAddress, @cstArea, @cstMob_No, @cstPhone_No, @cstBank_Account_No, '" + Cylinder_Type + "', @cstNo_of_Cylinder, @cstUser_Name)";
                    Cmd.Parameters.Add("@cstDate", SqlDbType.Date).Value = dtp_Date_of_Connection.Text;
                    Cmd.Parameters.Add("@cstCust_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    Cmd.Parameters.Add("@cstF_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                    Cmd.Parameters.Add("@cstM_Name", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                    Cmd.Parameters.Add("@cstL_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                    Cmd.Parameters.Add("@cstAadhar_No", SqlDbType.BigInt).Value = tb_Aadhar_No.Text;
                    Cmd.Parameters.Add("@cstPAN_No", SqlDbType.NVarChar).Value = tb_PAN_Card_No.Text;
                    Cmd.Parameters.Add("@cstAddress", SqlDbType.NVarChar).Value = tb_Address.Text;
                    Cmd.Parameters.Add("@cstArea", SqlDbType.NChar).Value = tb_Area.Text;
                    Cmd.Parameters.Add("@cstMob_No", SqlDbType.BigInt).Value = tb_Mobile_No.Text;

                    if (tb_Phone_No.Text != "")
                    {
                        Cmd.Parameters.Add("@cstPhone_No", SqlDbType.BigInt).Value = tb_Phone_No.Text;
                    }
                    else
                    {
                        Cmd.Parameters.Add("@cstPhone_No", SqlDbType.BigInt).Value = 0;
                    }

                    Cmd.Parameters.Add("@cstBank_Account_No", SqlDbType.BigInt).Value = tb_Bank_Account_No.Text;
                    Cmd.Parameters.Add("@cstNo_of_Cylinder", SqlDbType.Int).Value = cmb_No_of_Cylinder.Text;
                    Cmd.Parameters.Add("@cstUser_Name", SqlDbType.VarChar).Value = Global_Vars.Uname;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Global_Vars.Customer_ID = Convert.ToInt32(tb_Customer_ID.Text);

                    Clear_Controls();

                    frm_Payments obj = new frm_Payments();
                    obj.TopLevel = false;
                    obj.Parent = this;
                    obj.Show();


                }
                else
                {
                    MessageBox.Show("First Fill All the Fields");
                }

                Con_Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
    }
}
