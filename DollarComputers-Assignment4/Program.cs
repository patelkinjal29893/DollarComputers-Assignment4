//App Name : Program   
//Author's Name : Kinjal Patel
//Student ID : 200334364    
//App Creation Date : 8th March, 2017
//App Description : This Program form is the main Entry point for the application 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DollarComputers_Assignment4.Models;

namespace DollarComputers_Assignment4
{
 
    static class Program
    {
        //Create a static object of product 
        public static product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Initiate object of product
            product = new product();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
