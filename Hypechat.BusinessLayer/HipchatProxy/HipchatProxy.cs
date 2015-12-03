using Windows.Web.Http;

namespace Hypechat.BusinessLayer.HipchatProxy
{
    public abstract class HipchatProxy
    {
        protected readonly HttpClient _hipchatClient;

        protected HipchatProxy(HttpClient hipchatClient = null)
        {
            this._hipchatClient = hipchatClient ?? HipchatHttpClient.Instance;
        }
    }
}
