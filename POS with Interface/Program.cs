using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_with_Interface
{
    static class Program
    {
        
        public static bool adapt = false;
        public static List<Product> productList;
        public static List<Basket> basketlist;
        public static Decimal saleTotal = 0.00M;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            productList = new List<Product>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
