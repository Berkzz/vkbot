using System;
using System.Collections.Generic;
using System.Text;
using VkNet;
using VkNet.Model;

namespace VkBot
{
    class EventHandler
    {
        private static bool isConversation(Message m)
        {
            return m.PeerId.Value > 2000000000;
        }
        public static void Handle(VkApi api, Message m)
        {
            Console.WriteLine(isConversation(m));
            if(isConversation(m))
            {
                Console.WriteLine("isConv");
                api.Messages.MarkAsRead(m.PeerId.ToString(), (long) m.Id);
            }
            
        }
    }
}
