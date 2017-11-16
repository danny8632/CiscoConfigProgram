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
        public HostNameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommandInput.hostname = HostNameInputBox.Text;

            if(CommandInput.hostname == "")
            {
                MessageBox.Show("Intet hostname indtastet");
            }

            Form2.ChangeHostname();
            Hide();
        }
    }
}
