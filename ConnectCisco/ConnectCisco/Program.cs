using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectCisco
{
    class Program
    {
        static void Main(string[] args)
        {
            TelnetConnection T = new TelnetConnection("192.168.1.1", 23);
            T.CiscoLogin("Password1");
            T.CiscoEnable("Password1");
            T.CiscoCommand("conf t");
            //T.CiscoCommand("banner motd #Lolllllll#");
            T.CiscoCommand("hostname gulerod");
            T.CiscoCommand("exit");
            T.CiscoCommand("write");
        }
    }
}
