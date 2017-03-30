// App Name : Product Info Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : March 8, 2017
// App Description : It will displays different Information of Product that you have choose for.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DollarComputers_Assignment4.Models;

namespace DollarComputers_Assignment4
{
    public partial class ProductInfoForm : Form
    {
        //Reference for previous Form
        public Form previousForm;

        //Connect to the Database Using dbContext Object
        private ProductsContext dbProduct = new ProductsContext();

        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is handler for Open Select Form when Select Button Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            //Create an Object of SelectForm
            SelectForm selectForm = new SelectForm();
            selectForm.previousForm = this;

            //Hides this ProductInfoForm
            this.Hide();

            //Displays SelectForm when Button is Clicked
            selectForm.Show();
        }
        /// <summary>
        /// This is handler for Exit From the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is handler to redirect User into OrderForm to Complete Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //Create an Object of OrderForm
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;

            //Hides the ProductInfoForm
            this.Hide();

            //Display OrderForm for Complete Order
            orderForm.Show();
        }
        /// <summary>
        /// This is handler for Exit Menu Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton_Click(sender, e);
        }
        /// <summary>
        /// This is the handler for Select Another Product Menu Strip from the Edit Menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAnotherProductButton_Click(sender, e);
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //It displays Products basic Information
            ProductIDTextBox.Text = Program.product.productID.ToString();
            ConditionTextBox.Text = Program.product.condition;
            CostTextBox.Text = "$ " + Math.Round(Convert.ToDouble(Program.product.cost),2).ToString();

            //It displays Products Information into Product Info GroupBox
            PlatformTextBox.Text = Program.product.platform;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            OSTextBox.Text = Program.product.OS;
            ModelTextBox.Text = Program.product.model;

            //It displays  Products Tech Specs Information into Tech Specs GroupBox
            MemoryTextBox.Text = Program.product.RAM_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUTypeTextBox.Text = Program.product.CPU_type;

            LCDSizeTextBox.Text = Program.product.screensize;
            CPUNumberTextBox.Text = Program.product.CPU_number;
            CPUSpeedTextBox.Text = Program.product.CPU_speed;

            HDDTextBox.Text = Program.product.HDD_size;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            WebCamTextBox.Text = Program.product.webcam;
            
        }
    }
}
