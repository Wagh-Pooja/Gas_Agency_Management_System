using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gas_Agency_Management_System
{
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void frm_Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_Splash.PerformStep();

            if (pb_Splash.Value <= 10)
            {
                lbl_Application_Is_Loading.Text = "Loading Application Please Wait...";
            }

            if (pb_Splash.Value >= 10 && pb_Splash.Value <= 20)
            {
                lbl_Application_Is_Loading.Text = "Loading Forms Please Wait...";
            }

            if (pb_Splash.Value >= 20 && pb_Splash.Value <= 50)
            {
                lbl_Application_Is_Loading.Text = "Starting Application Please Wait...";
            }

            if (pb_Splash.Value >= 50 && pb_Splash.Value <= 75)
            {
                lbl_Application_Is_Loading.Text = "Loading Database Please Wait...";
            }

            if (pb_Splash.Value >= 75 && pb_Splash.Value <= 85)
            {
                lbl_Application_Is_Loading.Text = "Loading And connection to Database Please Wait...";
            }

            if (pb_Splash.Value >= 85 && pb_Splash.Value <= 100)
            {
                lbl_Application_Is_Loading.Text = "Loging Form Is Opening Please Wait...";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            System.Threading.Thread.Sleep(200);
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity <= 0)
            {
                timer3.Enabled = false;

                frm_Login_Screen obj = new frm_Login_Screen();
                obj.Show();
                this.Hide();
               
            }
        }
  
    }
}
