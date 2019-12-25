using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplicationSpeech.Class
{
  public  class admin
    {
      public  string id;
      public  string name;
      public  string phone;
      public  string Username;
      public  string Password;
        
        public admin()
        {
        }
      public  admin(string i, string n, string p,string name, string pass)
        {
           id = i;
           name = n;
           phone = p;
           Username = name;
           Password = pass;
        }
     public admin(string name, string pass)
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
