using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCiscoSetup
{
    public partial class Form1 : Form
    {
        //LoginClass login = new LoginClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            LoginClass.ip = ipInput.Text;

            if (!int.TryParse(portInput.Text, out LoginClass.port))
            {
                MessageBox.Show("Det ikke et korrekt tal du har indsat");
            }

            LoginClass.pass1 = password1.Text;
            LoginClass.pass2 = password2.Text;

            if(LoginClass.ip == "")
            {
                MessageBox.Show("Indsæt et ip");
            } else if (LoginClass.port == 0)
            {
                MessageBox.Show("Indsæt et port");
            } else if (LoginClass.pass1 == "")
            {
                MessageBox.Show("Indsæt password");
            } else if (LoginClass.pass2 == "")
            {
                MessageBox.Show("Indsæt password");
            } else
            {
                Form2 Check = new Form2();
                Check.Show();
                Hide();
            }

            

        }
    }
    public static class LoginClass
    {
        public static string ip;
        public static int port;
        public static string pass1;
        public static string pass2;
    }
}
