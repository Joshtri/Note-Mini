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

namespace Note_Mini___Console___WinForms.Login_SignIn
{
    public partial class SignUp : LoginForm
    {

        public SqlConnection Cons = new SqlConnection(@"Data Source=DESKTOP-05LLTVO;Initial Catalog=DB-Notes;Integrated Security=True;");

      
        public SignUp()
        {
            
            InitializeComponent();
           
        }


        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string Genders = "";
            if (RadMale.Checked)
            {
                Genders = "Male"; 
            }

            else if (RadFemale.Checked)
            {
                Genders = "Female"; 
            }

            //write the querry
            SqlCommand SqlQuerry = new SqlCommand("INSERT INTO Users VALUES(@Name,@Password,@Email,@Phone,@Gender)",Cons);

            Cons.Open();
            //add the value into the column at DB.
            SqlQuerry.Parameters.AddWithValue("@Name" , UsernameBox.Text);
            SqlQuerry.Parameters.AddWithValue("@Password", PassBox.Text);
            SqlQuerry.Parameters.AddWithValue("@Email",MailBox.Text);
            SqlQuerry.Parameters.AddWithValue("@Phone",PNumberBox.Text);

            SqlQuerry.Parameters.AddWithValue("@Gender", Genders);

            if ("@Name" == "@Name")
            {
                MessageBox.Show("Another Username already exist", MessageBoxButtons.OK.ToString());
                UsernameBox.Clear();

                Cons.Close();
            }

            SqlQuerry.ExecuteNonQuery();

            Cons.Close();
        }
    }
}
