using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationSpeech.Class
{
    class stutter
    {

        public
          string id;
        string name;
        string phone;
        string Username;
        string Password;

        stutter()
        {
            id = "0";
            name = "0";
            phone = "0";
            Username = "0";
            Password = "0";
        }
        stutter(string i, string n, string p, string name, string pass)
        {
            id = i;
            name = n;
            phone = p;
            Username = name;
            Password = pass;
        }
        void Login(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
        public bool Login()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count( *)  From Deaf where Username='" + this.Username + "' and Password='" + this.Password + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                return true;
            return false;
        }
    }
}

