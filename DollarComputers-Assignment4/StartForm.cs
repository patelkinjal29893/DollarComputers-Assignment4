// App Name : Start Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : March 8, 2017
// App Description : This is first Start form to display Different Options for buying Computers.

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
    public partial class StartForm : Form
    {         
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is a handler for Exit Button click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is a handler for Start Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Create an Object of SelectForm
            SelectForm selectForm = new SelectForm();            
            selectForm.previousForm = this;
            
            //Hides this StartForm
            this.Hide();
            
            //Displays new SelectForm
            selectForm.Show();
        }
        /// <summary>
        /// This is a handler for Open Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Create an Object of ProductInfoForm
            ProductInfoForm productInfoForm = new ProductInfoForm();            

            //Close this StartForm
            this.Close();

            //Displays new ProductInfoForm
            productInfoForm.Show();
        }
    }
}
