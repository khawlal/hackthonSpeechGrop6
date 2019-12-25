using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationSpeech
{
    public partial class singUp : Form
    {
        public singUp()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO [deaf] VALUES (@id,@name,@phon,@Username,@Password", con); 
           /**
            sda.Parameters.AddWhithValus("name",textBox1.Text);
            sda.Parameters.AddWhithValus("id", textBox2.Text);
            sda.Parameters.AddWhithValus("phone", textBox3.Text);
            sda.Parameters.AddWhithValus("Usernam", textBox4.Text);
            sda.Parameters.AddWhithValus("Password", textBox5.Text);
    **/
            
        }

        
    }
}
