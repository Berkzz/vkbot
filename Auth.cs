using System;
using System.Collections.Generic;
using System.Text;
using VkNet;
using VkNet.Model;

namespace VkBot
{
    class Auth
    {
        public static void AuthUser(VkApi api, string token)
        {
            api.Authorize(new ApiAuthParams
            {
                AccessToken = token
            });

        }
    }
}
