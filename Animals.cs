using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace VkBot
{
    class Animals
    {
        public static string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        public static string GetAnimal(string type)
        {
            return Get("http://shibe.online/api/" + type + "?count=1&urls=true&httpsUrls=true").Replace("[", "").Replace("\"", "").Replace("]", "");
        }
    }
}
