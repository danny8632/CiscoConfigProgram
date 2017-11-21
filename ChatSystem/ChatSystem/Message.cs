using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem
{
    public class Message
    {
        public string message { get; set; }

        public string roomName { get; set; }

        public DateTime time { get; set; }
    }
}
