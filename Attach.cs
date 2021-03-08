using System;
using System.Net;
using System.Text;
using VkNet;

namespace VkBot
{
    class Attach
    {
        public static System.Collections.ObjectModel.ReadOnlyCollection<VkNet.Model.Attachments.Photo> UploadPictureURL(VkApi api, string pictureURL, long peerId)
        {
            var wc = new WebClient();
            wc.DownloadFile(pictureURL, @"temp.png");
            var responseImg = Encoding.ASCII.GetString(wc.UploadFile(api.Photo.GetMessagesUploadServer(peerId).UploadUrl, @"temp.png"));
            return api.Photo.SaveMessagesPhoto(responseImg);
        }
        public static System.Collections.ObjectModel.ReadOnlyCollection<VkNet.Model.Attachments.Photo> UploadPictureLocal(VkApi api, string pictureDirectory, long peerId)
        {
            var wc = new WebClient();
            var responseImg = Encoding.ASCII.GetString(wc.UploadFile(api.Photo.GetMessagesUploadServer(peerId).UploadUrl, pictureDirectory));
            return api.Photo.SaveMessagesPhoto(responseImg);
        }
    }
}
