using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gas_Agency_Management_System.Report;

namespace Gas_Agency_Management_System
{
    public partial class frm_Gas_Agency_Management_System : Form
    {
        public frm_Gas_Agency_Management_System()
        {
            InitializeComponent();
            pnl_SubCustomer.Visible = false;
            pnl_SubBooking.Visible = false;          
            pnl_SubCylinder.Visible = false;
            pnl_subStock.Visible = false;
            pnl_Sub_Report.Visible = false;
        }

        public void Hide_allSubmenu()
        {
            if (pnl_SubCustomer.Visible == true)
            {
                pnl_SubCustomer.Visible = false;
            }

            if (pnl_SubBooking.Visible == true)
            {
                pnl_SubBooking.Visible = false;
            }
          
            if (pnl_SubCylinder.Visible == true)
            {
                pnl_SubCylinder.Visible = false;
            }

            if (pnl_subStock.Visible == true)
            {
                pnl_subStock.Visible = false;
            }

            if (pnl_Sub_Report.Visible == true)
            {
                pnl_Sub_Report.Visible = false;
            }

        }
        public void Show_Menu(Panel panel)
        {
            if (panel.Visible == false)
            {
                Hide_allSubmenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        private void frm_Gas_Agency_Management_System_Load(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Show_Menu(pnl_SubCustomer);
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            Show_Menu(pnl_SubBooking);
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer obj = new frm_Add_New_Customer();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Update_Customer_Click(object sender, EventArgs e)
        {
            frm_Update_Customer obj = new frm_Update_Customer();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_View_All_Customer_Click(object sender, EventArgs e)
        {
            frm_View_All_Customer obj = new frm_View_All_Customer();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show(); 
        }

        private void btn_New_Booking_Click(object sender, EventArgs e)
        {
            frm_Add_New_Booking obj = new frm_Add_New_Booking();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show(); 
        }

        private void btn_Cylinder_Click(object sender, EventArgs e)
        {
            Show_Menu(pnl_SubCylinder);
        }

        private void btn_View_All_Booking_Click(object sender, EventArgs e)
        {
            frm_View_All_Booking obj = new frm_View_All_Booking();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show(); 
        }

        private void btn_Set_Cylinder_Price_Click(object sender, EventArgs e)
        {
            frm_Set_Cylinder_Price obj = new frm_Set_Cylinder_Price();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Top;
            this.pnl_main.Controls.Add(obj);
            obj.Show(); 
        }

        private void btn_Cylinder_Stock_Click(object sender, EventArgs e)
        {
            frm_Stock obj = new frm_Stock();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show(); 
        }

        private void btn_View_Cylinder_Stock_Click(object sender, EventArgs e)
        {
            frm_View_Cylinder_Stock obj = new frm_View_Cylinder_Stock();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Search_Customer_Click(object sender, EventArgs e)
        {
            frm_Search_Customer obj = new frm_Search_Customer();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Menu(pnl_subStock);
        }

        private void btn_Cylinder_Status_Click(object sender, EventArgs e)
        {
            frm_View_Sale_Stock obj = new frm_View_Sale_Stock();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();

        }

        private void pnl_SubCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Complaint_Click(object sender, EventArgs e)
        {
            frm_Complaint obj = new frm_Complaint();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Show_Menu(pnl_Sub_Report);
        }

        private void btn_Single_Customer_Click(object sender, EventArgs e)
        {
            frm_Single_Customer_Report obj = new frm_Single_Customer_Report();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Customer_Payment_Click(object sender, EventArgs e)
        {
            frm_Customer_Payment_Report obj = new frm_Customer_Payment_Report();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Customer_Booking_Click(object sender, EventArgs e)
        {
            frm_Customer_Booking_Report obj = new frm_Customer_Booking_Report();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Customer_Complaint_Click(object sender, EventArgs e)
        {
            frm_Customer_Complaint_Report obj = new frm_Customer_Complaint_Report();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Cyl_Stock_Click(object sender, EventArgs e)
        {
            frm_Cylinder_Stock_Report obj = new frm_Cylinder_Stock_Report();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();

        }

        private void btn_Sale_Stock_Click(object sender, EventArgs e)
        {
            frm_Sale_Cylinder_Report obj = new frm_Sale_Cylinder_Report();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(obj);
            obj.Show();
        }
    }
}
