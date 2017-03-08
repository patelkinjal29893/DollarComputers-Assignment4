// App Name : Splash Screen
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : March 8, 2017
// App Description : This is a Splash Screen.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers_Assignment4
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            //It will disable the Timer
            SplashScreenTimer.Enabled = false;

            //It will hide the SplashScreen
            this.Hide();
           
            StartForm startForm = new StartForm();

            //Display the Next Start Form
            startForm.Show();

        }
    }
}
