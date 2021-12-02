using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_with_Interface
{
    public partial class AddProd : Form
    {

        public AddProd()
        {
            InitializeComponent();
        }

        private void AddProd_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdbtn_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.Id = Convert.ToInt32(ProdID.Text());
            product.Name = ProdName.Text();
            product.Price = Convert.ToDecimal(ProdPrice.Text());
            productlist.add(product);
            this.Hide();
            new AdminMenu().Show();
        }
    }
}
