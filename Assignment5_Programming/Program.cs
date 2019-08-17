using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5_Programming.Models;
using Assignment5_Programming.Views;
using Assignment5_Programming.Properties;

namespace Assignment5_Programming.Views
{
   public static class Program
    {
        // These are the static members 
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // form instantiating here
            splashForm = new SplashForm();
            selectForm = new SelectForm();
            startForm = new StartForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();

            product = new Product();
            
            Application.Run(splashForm);
        }
    }
}
