using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            formLogin FormLogin = new formLogin();

            FormLogin.ShowDialog();

            lblCurrentUser.Text = FormLogin.UserName;

            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblCurrentUser.Text = "None";

            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
        }
    }
}
