//App Name : Order Form 
//Author's Name : Kinjal Patel
//Student ID : 200334364    
//App Creation Date : 8th March, 2017
//App Description : It will Displays Final Order form will all Selected Information to place the Order

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

        /// <summary>
        /// This is handler for Back Button CLick event that sends you back into ProductInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        { 
            //Create an Instance of ProductInfoForm
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;

            //It will hide this OrderForm
            this.Hide();

            //Shows the back ProductInfoForm
            productInfoForm.Show();
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selection is about to Printing...");
        }
        /// <summary>
        /// This is handler for back MenuStrip from shared Event of Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
        }
        /// <summary>
        /// This is for Cancel Button to Terminate Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This handler for exit menu Strip to terminate Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton_Click(sender, e);
        }
        /// <summary>
        /// This handler is for finish the Order and Terminate the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            //Displays new MessageBox with below information when Cancel button will clicked
            MessageBox.Show("Thank you for choosing Dollar Computers...  " +
                "Your order will be processed in 7-10 Business Days");

            Application.Exit();
        }
        /// <summary>
        /// This is handler for OrderForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {            
            //It will fill up all TextBoxes with user selected option
            //Display Product Components 
            ConditionTextBox.Text = Program.product.condition;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            PlatformTextBox.Text = Program.product.platform;
            ModelTxtBox.Text = Program.product.model;

            //Display all Specifications of User Selected Choice
            LCDSizeTextBox.Text = Program.product.screensize;
            MemoryTextBox.Text = Program.product.RAM_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            CPUnumberTextBox.Text = Program.product.CPU_number;
            CPUSpeedTextBox.Text = Program.product.CPU_speed;
            HDDTextBox.Text = Program.product.HDD_size;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            WebCamTextBox.Text = Program.product.webcam;
            OSTextBox.Text = Program.product.OS;

            //Calculate Total Sales tax on Laptop Prices
            double price = Math.Round(Convert.ToDouble(Program.product.cost),2);
            double baseSalesTax = Convert.ToDouble(Program.product.cost);
            double finalSaleTax = Math.Round(baseSalesTax * 0.13,2);
            double totalAmount = price + finalSaleTax;

            //Display all total prices with sales tax in all TextBoxes
            PriceTextBox.Text = "$" + price.ToString();
            SalesTaxTextBox.Text = "$" + finalSaleTax.ToString();
            TotalTextBox.Text = "$" + totalAmount.ToString();
        }
    }
}
