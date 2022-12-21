using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtPassword.Text;
            if (username=="hms"&&pass=="pass")
            {
                //MessageBox.Show("Accessed.");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong id or password.");
            }
        }
    }
}
