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
    public partial class NewPass : Form
    {
        public static bool newp = false;
        public NewPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OldPass == "password")
            {
                newp = true;
                Newpas.Text = NewPass;
            }
            new AdminMenu().Show();
            this.Hide();
        }
    }
}
