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
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (usrbox.Text == "admin")
            {
                if (newp = true)
                {
                    if (pswdbox == NewPass)
                    {
                        new AdminMenu().Show();
                        this.Hide();
                    }
                }
                else if (pswdbox.Text == "password")
                {

                    new AdminMenu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cocked up your password mate!!!");
                }
            }
        }
    }
}
