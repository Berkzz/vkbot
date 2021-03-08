using System;
using VkNet;
using VkNet.Model.RequestParams;

namespace VkBot
{
    class VkBot
    {
        static void Main(string[] args)
        {
            string token = "---------"; // user token
            var api = new VkApi();
            var User = new User(api, token);
            User.SendMessage("", Animals.GetAnimal("shibes"), 582751238);
            Events.Start(api);
        }
    }
}
