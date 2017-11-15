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
            SerialPort stream = new SerialPort();

            stream.PortName = "COM3";
            stream.BaudRate = 9600;
            stream.DataBits = 8;
            stream.Parity = Parity.None;
            stream.StopBits = StopBits.One;

            stream.Open();
            stream.WriteLine("enable");
            stream.WriteLine("conf t");
            stream.WriteLine("banner motd #Welcome Authorized Users Unauthorized access prohibited!# ");
            stream.Close();

            Console.ReadKey();
        }
    }
}
