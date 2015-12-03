using System;
using System.Net;
using System.Net.Http;

namespace Hypechat.BusinessLayer.HipchatProxy
{
    public sealed class HipchatHttpClient
    {
        private static volatile HttpClient instance;
        private static object syncRoot = new object();
        private const string HipchatBaseAddress = "https://api.hipchat.com/v2";

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
                                BaseAddress = new Uri(HipchatBaseAddress)
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
