using System.Collections;
using System.Threading.Tasks;

using HypeChat.Models;

namespace HypeChat.HipchatProxy
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
