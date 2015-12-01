using System.Net.Http;

namespace HypeChat.Hipchat
{
    public class HipchatProxy
    {
        private readonly HttpClient _hipchatClient;

        public HipchatProxy(HttpClient hipchatClient)
        {
            _hipchatClient = hipchatClient ?? HipchatHttpClient.Instance;
        }
    }
}
