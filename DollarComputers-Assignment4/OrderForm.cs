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
    public partial class OrderForm : Form
    {
        //Reference for previous Form
        public Form previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is handler to Display AboutBox using about MenuStrips
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Created Instance of AboutBox
            AboutBox aboutBox = new AboutBox();

            //Displays about box in the new Window
            aboutBox.ShowDialog();
        }
    }
}
