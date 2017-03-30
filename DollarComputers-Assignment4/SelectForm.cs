// App Name : Select Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : March 8, 2017
// App Description : It will displays different Computers list to buyer.

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
using System.Diagnostics;

namespace DollarComputers_Assignment4
{
    public partial class SelectForm : Form
    {
        //Reference for previous Form
        public Form previousForm;

        //Create an instance of ProductInfoForm
        ProductInfoForm productInfoForm = new ProductInfoForm();
        
        //Connect to the Database Using dbContext Object
        private ProductsContext dbProduct = new ProductsContext();
        public SelectForm()
        {
            InitializeComponent();
        }
        private void SelectForm_Load(object sender, EventArgs e)
        {
            //Create a object to get products table data from Database
            List<product> ProductList = (from product in dbProduct.products
                                         select product).ToList();

            ProductListDataGridView.DataSource = ProductList;
            productInfoForm.previousForm = this;            
        }
        /// <summary>
        /// This handler will terminate application when Cancel Button Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Event Handler for Next Button CLick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;

            this.Hide();

            productInfoForm.Show();          
        }              
        /// <summary>
        /// Event handler for DataGridView Selection Index changed and Display data into TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //For select full row from DataGridView
            this.ProductListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            //Select the current row from GridView
            this.ProductListDataGridView.CurrentRow.Selected = true;

            //Bound Selected data into TextBox
            Program.product = (product)ProductListDataGridView.CurrentRow.DataBoundItem;        
            YourSelectionTextBox.Text = Program.product.manufacturer + " " +
                                        Program.product.model + " Priced at: $" +
                                        Math.Round(Convert.ToDouble(Program.product.cost), 2);
        }
    }
}
