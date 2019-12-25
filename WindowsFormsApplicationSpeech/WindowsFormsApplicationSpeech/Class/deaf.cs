using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationSpeech.Class
{
    class deaf
    {

        public
         string id;
        string name;
        string phone;
        string Username;
        string Password;

        deaf()
        {
            id = "0";
            name = "0";
            phone = "0";
            Username = "0";
            Password = "0";
        }
        deaf(string i, string n, string p, string name, string pass)
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
    }
}

