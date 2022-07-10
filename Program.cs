using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Note_Mini___Console___WinForms.Login_SignIn;


namespace Note_Mini___Console___WinForms
{
    internal class Program
    {
        static void Main()
        {

            String Creator = "\'Yosry Lenggu\'";
            
            Console.WriteLine("--Click Enter To Continue--");
           
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("--Hello, welcome in my Notes program by {0}--",Creator);
                Console.Clear();
                Console.WriteLine("--Click Enter To Get In The Program--");
                Console.Clear();
                if (key == ConsoleKey.Enter)
                {
                    //Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(true);

                    Application.Run(new Login_N_Sign());
                }
            }

           



            

            





            //LoginForm dt = new LoginForm();
            //dt.Show();
        }
    }
}
