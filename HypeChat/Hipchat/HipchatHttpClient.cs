using System;
using System.Net.Http;
using System.Net;
namespace HypeChat.Hipchat
{
    public sealed class HipchatHttpClient
    {
        private static HttpClient instance;
        private static object syncRoot = new object();
        private const string hipchatBaseAddress = "https://api.hipchat.com/v2";

        public static HttpClient Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            var handler = new HttpClientHandler { UseDefaultCredentials = true, Credentials = CredentialCache.DefaultCredentials };
                            var client = new HttpClient(handler, false)
                            {
                                BaseAddress = new Uri(hipchatBaseAddress)
                            };
                            instance = client;
                        }
                    }
                }

                return instance;
            }
        }
    }
}
