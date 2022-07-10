using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Mini___Console___WinForms.Login_SignIn
{
    public partial class Login_N_Sign : Form
    {
        public Login_N_Sign()
        {
            InitializeComponent();
        }

        //instansiasi form. 
        LoginForm Loginfrm = new LoginForm();

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (Loginfrm == null || Loginfrm.IsDisposed)
            {
                Loginfrm = new LoginForm();

            }
          
            Loginfrm.Show(); 
            Loginfrm.BringToFront();
            Hide();
            
        }
    }
}
