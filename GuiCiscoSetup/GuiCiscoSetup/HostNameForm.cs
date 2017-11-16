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
                CommandInput.hostnameint = 1;
                Hide();
            }
            
            //Form2.ChangeHostname();
            
        }
    }
}
