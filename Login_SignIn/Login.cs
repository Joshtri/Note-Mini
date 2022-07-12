using Note_Mini___Console___WinForms.Login_SignIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Note_Mini___Console___WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
       
         
       
        private void GoToSign_Click(object sender, EventArgs e)
        {
            SignUp signForm = new SignUp();

            if (signForm == null || signForm.IsDisposed)
            {
                signForm = new SignUp(); 
            }
            this.Cursor = Cursors.Hand;
            GoToSign.Cursor = Cursors.Hand;


            signForm.Show();
            signForm.BringToFront();
            Hide();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if ("@Name" == "@Name" && "@Password" == "@Password")
            {
                MessageBox.Show("Oke");
            }

            else if("@Name" != "@Name" || "@Password" == "@Password")
            {
                MessageBox.Show("Try Again");
            }

        }
    }
}
