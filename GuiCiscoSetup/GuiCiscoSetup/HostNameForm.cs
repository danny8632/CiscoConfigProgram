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
    public partial class HostNameForm : Form
    {
        TelnetConnection T = new TelnetConnection(LoginClass.ip, LoginClass.port);
        Form2 f = new Form2();
        public HostNameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hostname = HostNameInputBox.Text;

            if(CommandInput.hostname == "")
            {
                MessageBox.Show("Intet hostname indtastet");
            }else
            {
                T.CiscoLogin(LoginClass.pass1);
                T.CiscoEnable(LoginClass.pass2);
                T.CiscoCommand("conf t");
                CommandInput.hostNameBool = true;
                T.CiscoCommand("banner motd " + hostname);
                T.CiscoCommand("exit");
                T.CiscoCommand("write");
                MessageBox.Show(hostname);
                CommandInput.hostNameBool = false;
                Hide();
            }
            
            //Form2.ChangeHostname();
            
        }
    }
}
