using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formLogin : Form
    {
        private string userName,userPassword;

        public formLogin()
        {
            InitializeComponent();
        }

        public string UserName {
            get { return userName; }
        }


        public string UserPassword {
            get { return userPassword; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = tboxUsername.Text;
            userPassword = tboxPassword.Text;

            this.Close();
        }
       
    }
}
