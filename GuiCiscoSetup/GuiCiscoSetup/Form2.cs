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
    public partial class Form2 : Form
    {
        TelnetConnection T = new TelnetConnection(LoginClass.ip, LoginClass.port);
        public Form2()
        {
            InitializeComponent();
            
        }

        
        

        public void button1_Click(object sender, EventArgs e)
        {
            //LoginClass login = new LoginClass();


            HostNameForm fo = new HostNameForm();
            fo.Show();



        }
    }
    public static class CommandInput
    {
        public static string hostname;
        public static int hostnameint;
        public static bool hostNameBool;
    }
}
