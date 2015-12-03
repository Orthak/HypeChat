using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hypechat.Models;
using Windows.Data.Json;

namespace Hypechat.BusinessLayer.HipchatProxy
{
    public class HipchatRoomsService : HipchatProxy
    {
        public async Task<HipchatRoom> GetHipchatRoom(string roomName)
        {
            var resourcePath = new Uri(@"room/"+roomName);
            var response = await this._hipchatClient.GetAsync(resourcePath);
            return null;
        }

        public async Task<HipchatRoom> GetHipchatRoom(int roomId)
        {
            var resourcePath = new Uri(@"room/" + roomId);
            var response = await this._hipchatClient.GetStringAsync(resourcePath);
            var jsonArray = JsonArray.Parse(response);

            var room = new HipchatRoom()
            {
                RoomName = ((JsonObject)jsonArray[0])["RoomName"].GetString()
            };

            return room;
        }
    }
}
