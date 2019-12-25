using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplicationSpeech.Class;

namespace WindowsFormsApplicationSpeech
{
    public partial class FrmLogin : Form 
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //only deaf can access, deaf button(log in deaf)
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count( *)  From Deaf where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "' ", con);
            admin aa = new admin(textBox1.Text, textBox2.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //MessageBox.Show("LOGIN Done");
                this.Hide();
                deaf ss = new deaf();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check you Username and Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Exit button
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        // only admin can access, admin button(log in Admin)
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count( *)  From Admin where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "' ", con);
            admin aa = new admin(textBox1.Text,textBox2.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("LOGIN Done");
                this.Hide();
                //SpeakForm ss = new SpeakForm();
                //ss.Show();
            }
            else
            {
                MessageBox.Show("Please check you Username and Password");
            }
        }
        // only Stutter can access, Stutter button(log in Stutter)
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count( *)  From Stutter where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "' ", con);
            admin aa = new admin(textBox1.Text, textBox2.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               MessageBox.Show("LOGIN Done");
                this.Hide();
                //SpeakForm ss = new SpeakForm();
                //ss.Show();
            }
            else
            {
                MessageBox.Show("Please check you Username and Password");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
