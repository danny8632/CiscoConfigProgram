using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectCisco
{
    class Class1
    {
        static void Main(string[] args)
        {

            string fileName = "test1.txt";
            string ipAddres = "192.168.1.1";
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("C:\\Users\\felix\\Desktop\\skole stuff\\Programering\\Github\\Cisco config\\ConnectCisco\\ConnectCisco\\"+fileName, false, Encoding.ASCII);

                TelnetConnection T1;
                List<String> Result = new List<String>();
                int lineCounter = 3;

                T1 = new TelnetConnection(ipAddres, 23);

                T1.CiscoLogin("Password1");
                T1.CiscoEnable("Password1");
                Result = T1.CiscoCommand("Show running");

                Result.ForEach(delegate (String line)
                {
                    sw.WriteLine("{0}: {1}", lineCounter, line);
                    lineCounter++;
                });

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            Console.ReadKey();

            /*
            TelnetConnection T1;
            List<String> Result = new List<String>();
            int lineCounter = 1;

            T1 = new TelnetConnection("192.168.22.1", 23);

            T1.CiscoLogin("Password1");
            T1.CiscoEnable("Password2");
            Result = T1.CiscoCommand("Show running");

            Result.ForEach(delegate (String line)
            {
                Console.WriteLine("{0}: {1}", lineCounter, line);
                lineCounter++;
            });
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            */
        }
    }
}
