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
    public partial class frm_Update_Customer : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gas_Agency_Management_System_DB;Integrated Security=True");

        public frm_Update_Customer()
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
            cmb_Cylinder_Type.SelectedIndex = -1;
            tb_No_of_Cylinder.Text = "";
            tb_Customer_ID.Focus();
        }

        void Controls_Disable()
        {
            tb_First_Name.Enabled = false;
            tb_Middle_Name.Enabled = false;
            tb_Last_Name.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_PAN_Card_No.Enabled = false;
            tb_Address.Enabled = false;
            tb_Area.Enabled = false;
            tb_Mobile_No.Enabled = false;
            tb_Phone_No.Enabled = false;
            tb_Bank_Account_No.Enabled = false;
            cmb_Cylinder_Type.Enabled = false;
            tb_No_of_Cylinder.Enabled = false;
        }
        void Controls_Enable()
        {
            tb_First_Name.Enabled = true;
            tb_Middle_Name.Enabled = true;
            tb_Last_Name.Enabled = true;
            tb_Aadhar_No.Enabled = true;
            tb_PAN_Card_No.Enabled = true;
            tb_Address.Enabled = true;
            tb_Area.Enabled = true;
            tb_Mobile_No.Enabled = true;
            tb_Phone_No.Enabled = true;
            tb_Bank_Account_No.Enabled = true;
            cmb_Cylinder_Type.Enabled = true;
            tb_No_of_Cylinder.Enabled = true;
        }

        private void frm_Update_Customer_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Focus();
            Con_Open();

            cmb_Cylinder_Type.Items.Clear();

            SqlCommand cmd = new SqlCommand("Select Distinct(Cylinder_Type) from Customer_Details",Con);
            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Cylinder_Type.Items.Add(obj.GetString(obj.GetOrdinal("Cylinder_Type")));
            }

            obj.Dispose();

            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Controls_Disable();
            tb_Customer_ID.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                Con_Open();
            
                SqlCommand Cmd = new SqlCommand("Select * from Customer_Details where Customer_ID = " + tb_Customer_ID.Text + " ", Con);
                var obj = Cmd.ExecuteReader();
                if (obj.Read())
                { 
                    tb_First_Name.Text = obj.GetString(obj.GetOrdinal("First_Name"));
                    tb_Middle_Name.Text = obj.GetString(obj.GetOrdinal("Middle_Name"));
                    tb_Last_Name.Text = obj.GetString(obj.GetOrdinal("Last_Name"));
                    tb_Aadhar_No.Text = (obj["Aadhar_No"].ToString());
                    tb_PAN_Card_No.Text = (obj["PAN_Card_No"].ToString());
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Area.Text = obj.GetString(obj.GetOrdinal("Area"));
                    tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                    tb_Phone_No.Text = (obj["Phone_No"].ToString());
                    tb_Bank_Account_No.Text = (obj["Bank_Account_No"].ToString());
                    cmb_Cylinder_Type.Text = obj.GetString(obj.GetOrdinal("Cylinder_Type"));         
                    tb_No_of_Cylinder.Text = (obj["No_of_Cylinder"].ToString());
                    Controls_Enable();
                    tb_Customer_ID.Enabled = false;
                    tb_Aadhar_No.Enabled = false;
                    tb_PAN_Card_No.Enabled = false;
                    cmb_Cylinder_Type.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid Customer_ID");
                    tb_Customer_ID.Clear();
                    tb_Customer_ID.Focus();
                }
                
                obj.Dispose();
                Con_Close();
            }
            catch (Exception Ex )
            {
                MessageBox.Show(Ex.Message);
                
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if ( tb_Customer_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Address.Text != "" && tb_Area.Text != "" && tb_Mobile_No.Text != "" && tb_Bank_Account_No.Text != "" && cmb_Cylinder_Type.Text != "" &&  tb_No_of_Cylinder.Text != "" && Global_Vars.Uname != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Customer_Details Set First_Name = '" + tb_First_Name.Text + "',Middle_Name = '" + tb_Middle_Name.Text + "',Last_Name = '" + tb_Last_Name.Text + "',Address = '" + tb_Address.Text + "',Area = '" + tb_Area.Text + "',Mobile_No = " + tb_Mobile_No.Text + ",Phone_No = " + tb_Phone_No.Text + ",Bank_Account_No = " + tb_Bank_Account_No.Text + ", Cylinder_Type = '" + cmb_Cylinder_Type.Text + "' , No_of_Cylinder = " + tb_No_of_Cylinder.Text + " where Customer_ID = " + tb_Customer_ID.Text + "  ", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Update Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear_Controls();
                Controls_Disable();
                tb_Customer_ID.Clear();
                tb_Customer_ID.Enabled = true;
            }
            else
            {
                MessageBox.Show("First Fill All The Fields");
            }

            Con_Close();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Hide_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
