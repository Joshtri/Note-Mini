using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Note_Mini___Console___WinForms
{
    internal class Note
    {
        protected string UserName { get; set; }
        protected int Password { get; set; }

        string Stringscon = "";

        

        SqlConnection Con = new SqlConnection();

        public Note()
        {

        }
    }
}
