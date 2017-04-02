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
using System.IO;
using System.Diagnostics;

namespace DollarComputers_Assignment4
{
    public partial class ProductInfoForm : Form
    {
        //Reference for previous Form
        public Form previousForm;

        //Connect to the Database Using dbContext Object
        private ProductsContext dbProduct = new ProductsContext();
        
        //Create Private Variables
        private StreamWriter _writer;
        private StreamReader _reader;
        private Int32 _productID;
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
        /// <summary>
        /// This is handler of ProductInfoForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //Whenever User Open already saved file then openToolStripMenuItem activated
            if(Program.product.productID == 0)
            {
                this.Show();
                openToolStripMenuItem_Click(sender, e);
            }
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
        /// <summary>
        /// This is handler for save MenuStrip click Event for Save File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create Variables
            DialogResult result;
            string fileName;

            //Assign Properties to SaveDialog
            SaveProductFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            SaveProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SaveProductFileDialog.Title = "Save File";
            
            //Open DialogBox with the use of ShowDialog Method
            result = SaveProductFileDialog.ShowDialog();

            //If the result is OK then save the File
            if (result == DialogResult.OK)
            {
                fileName = SaveProductFileDialog.FileName;
                try
                {
                    //if Product file is already exist then It will delete it
                    if (File.Exists("Product.txt"))
                    {
                        File.Delete("Product.txt");
                    }
                    //Open a Saved Stream 
                    this._writer = new StreamWriter("Product.txt", true);
                    //Write all TextBox values in buffer
                    //Write Product basic Information
                    _writer.WriteLine(ProductIDTextBox.Text);
                    _writer.WriteLine(ConditionTextBox.Text);
                    _writer.WriteLine(CostTextBox.Text);

                    //Write Product basic Information
                    _writer.WriteLine(PlatformTextBox.Text);
                    _writer.WriteLine(ManufacturerTextBox.Text);
                    _writer.WriteLine(OSTextBox.Text);
                    _writer.WriteLine(ModelTextBox.Text);

                    //Write Product Tech Specs Information
                    _writer.WriteLine(MemoryTextBox.Text);
                    _writer.WriteLine(CPUBrandTextBox.Text);
                    _writer.WriteLine(CPUTypeTextBox.Text);
                    _writer.WriteLine(LCDSizeTextBox.Text);
                    _writer.WriteLine(CPUNumberTextBox.Text);
                    _writer.WriteLine(CPUSpeedTextBox.Text);
                    _writer.WriteLine(HDDTextBox.Text);
                    _writer.WriteLine(GPUTypeTextBox.Text);
                    _writer.WriteLine(WebCamTextBox.Text);
                   
                    _writer.Close(); //Flushes to buffers

                    MessageBox.Show("File Written Successfully", "File Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error Writing File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// This is handler for Open MenuStrip click event for Open Existing File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create Variables
            DialogResult result;
            string fileName;

            //Assign Properties to OpenDialog
            OpenProductFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            OpenProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenProductFileDialog.Title = "Open File";
            result = OpenProductFileDialog.ShowDialog();

            //If result is Ok then Open Saved File
            if(result == DialogResult.OK)
            {
                //pass value to the FileName
                fileName = OpenProductFileDialog.FileName;
                try
                {
                    this._reader = new StreamReader(fileName);

                    //If there is something to read
                    if(_reader.Peek() != -1)
                    {     
                        //Read all saved data from buffer using ReadLine 
                        //Read data of Product Basic Information                  
                        ProductIDTextBox.Text = this._reader.ReadLine();
                        ConditionTextBox.Text = this._reader.ReadLine();
                        CostTextBox.Text = this._reader.ReadLine();

                        //Read data of Product Basic Information from Product Info GroupBox
                        PlatformTextBox.Text = this._reader.ReadLine();
                        ManufacturerTextBox.Text = this._reader.ReadLine();
                        OSTextBox.Text = this._reader.ReadLine();
                        ModelTextBox.Text = this._reader.ReadLine();

                        //Read data of Tech Specs Information from Tech Specs GroupBox
                        MemoryTextBox.Text = this._reader.ReadLine();
                        CPUBrandTextBox.Text = this._reader.ReadLine();
                        CPUTypeTextBox.Text = this._reader.ReadLine();                    
                        LCDSizeTextBox.Text = this._reader.ReadLine();
                        CPUNumberTextBox.Text = this._reader.ReadLine();
                        CPUSpeedTextBox.Text = this._reader.ReadLine();
                        HDDTextBox.Text = this._reader.ReadLine();
                        GPUTypeTextBox.Text = this._reader.ReadLine();
                        WebCamTextBox.Text = this._reader.ReadLine();                        

                        _productID = Convert.ToInt32(ProductIDTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("File Empty -No data to read", "Error Reading File",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this._reader.Close();   //Flushes the Buffer                 
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error Reading File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Fetch Product Id from database and store into _productID variable            
                Program.product = (from product in dbProduct.products
                                   where product.productID == _productID
                                   select product).FirstOrDefault();
            }
        }
    }
}
