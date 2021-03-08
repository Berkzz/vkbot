using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using VkNet;
using VkNet.Model.RequestParams;
using System.Collections.ObjectModel;

namespace VkBot
{
    class User
    {
        VkApi api;

        public User(VkApi api, string token)
        {
            Auth.AuthUser(api, token);
            this.api = api;
        }

        public void SendMessage(string message, long peerId)
        {
            api.Messages.Send(new MessagesSendParams
            {
                RandomId = new Random().Next(),
                PeerId = peerId,
                Message = message
            });
        }

        public void SendMessageLocalPic(string message, string pictureDirectory, long peerId)
        {
            api.Messages.Send(new MessagesSendParams
            {
                RandomId = new Random().Next(),
                Attachments = Attach.UploadPictureLocal(api, pictureDirectory, (long) api.UserId),
                PeerId = peerId,
                Message = message
            });
        }

        public void SendMessage(string message, string pictureURL, long peerId)
        {
            api.Messages.Send(new MessagesSendParams
            {
                RandomId = new Random().Next(),
                Attachments = Attach.UploadPictureURL(api, pictureURL, (long) api.UserId),
                PeerId = peerId,
                Message = message
            });
        }



    }
}
