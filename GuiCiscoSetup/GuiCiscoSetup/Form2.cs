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
        
        public Form2()
        {
            InitializeComponent();
            
        }

        
        

        public void button1_Click(object sender, EventArgs e)
        {
            //LoginClass login = new LoginClass();
            TelnetConnection T = new TelnetConnection(LoginClass.ip, LoginClass.port);

            MessageBox.Show(LoginClass.ip);

            T.CiscoLogin(LoginClass.pass1);
            T.CiscoEnable(LoginClass.pass2);
            T.CiscoCommand("conf t");
            T.CiscoCommand("hostname julemand");
            T.CiscoCommand("exit");
            T.CiscoCommand("write");


        }
    }
}
