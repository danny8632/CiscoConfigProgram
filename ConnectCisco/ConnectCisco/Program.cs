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
        TelnetConnection T = new TelnetConnection("192.168.1.1", 23);
        static void Main(string[] args)
        {
            T.CiscoLogin("Password1");
            T.CiscoEnable("Password1");
            T.CiscoCommand("banner motd #Lol#");
        }
    }
}
