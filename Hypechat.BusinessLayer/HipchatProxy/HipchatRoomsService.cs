using System.Collections.Generic;
using System.Threading.Tasks;
using Hypechat.Models;

namespace Hypechat.BusinessLayer.HipchatProxy
{
    public class HipchatRoomsService : HipchatProxy
    {
        public async Task<HipchatRoom> GetHipchatRoom(string roomName)
        {
            var resourcePath = @"room/"+roomName;
            var response = await this._hipchatClient.GetAsync(resourcePath);
            return null;
        }

        public async Task<HipchatRoom> GetHipchatRoom(int roomId)
        {
            var resourcePath = @"room/" + roomId;
            var response = await this._hipchatClient.GetAsync(resourcePath);
            return null;
        }
    }
}
