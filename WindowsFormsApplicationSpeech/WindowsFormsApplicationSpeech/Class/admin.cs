using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
