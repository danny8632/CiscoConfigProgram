using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSystem
{
    public partial class ChatForm : Form
    {
        public Controller con = new Controller();
        LoginForm logfrm;
        public string currentUser;
        public ChatForm()
        {
            InitializeComponent();
            CreateData();
            logfrm = new LoginForm(this);
            logfrm.Show();
            
        }

        public void CreateData()
        {
            con.rooms.Add(new Room { name = "Generel" });

            con.users.Add(new User { id = 1, name = "John", password = "gemme" });
            con.users.Add(new User { id = 2, name = "Lukas", password = "gemme1" });
            

        }

        

        public void Login(string username, string password)
        {
            int wrongcounter2 = con.UserListCount();
            int wrongcounter = 1;
            foreach (User user in con.users)
            {
                if (username == user.name && password == user.password)
                {
                    currentUser = username;
                    MessageBox.Show(currentUser);
                    this.Show();
                    logfrm.Close();
                } else if (wrongcounter == wrongcounter2 )
                {
                    MessageBox.Show("Wong");
                }
                else
                {
                    wrongcounter++;
                }
                
            }
            //return "loged in";
        }

    }
}
