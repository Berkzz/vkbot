using System;
using VkNet;
using VkNet.Model.RequestParams;

namespace VkBot
{
    class VkBot
    {
        static void Main(string[] args)
        {
            //582751238
            string token = "---------"; // user token
            var api = new VkApi();
            var user = new User(api, token);
            user.SendMessage("", Animals.GetAnimal("shibes"), 582751238);
            Events.Start(api);
        }
    }
}
