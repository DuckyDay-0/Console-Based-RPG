using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class MessageHelper
    {
        private static Random random = new Random();

        public static string MsgRand(List<string> message)
        {
            return message[random.Next(message.Count)];
        }
    }
}
