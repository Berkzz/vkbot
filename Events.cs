using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using VkNet;
using VkNet.Model.RequestParams;

namespace VkBot
{
    class Events
    {
        public static void Start(VkApi api)
        {
            var longPollServer = api.Messages.GetLongPollServer();
            int messages = 0;
            while (true)
            {
                var longPollHistory = api.Messages.GetLongPollHistory(new MessagesGetLongPollHistoryParams
                {
                    Ts = ulong.Parse(longPollServer.Ts),
                    Pts = longPollServer.Pts

                });
                /*
                if (longPollHistory.Messages.Count > messages)
                {
                    Console.WriteLine(longPollHistory.Messages.Count);
                    Console.WriteLine(longPollHistory.Messages[0].PeerId);
                    EventHandler.Handle(api, longPollHistory.Messages[longPollHistory.Messages.Count - 1]);
                    messages = longPollHistory.Messages.Count;
                }
                Thread.Sleep(500);
                */
                // high CPU load
                // fix me
            }
        }
    }
}
