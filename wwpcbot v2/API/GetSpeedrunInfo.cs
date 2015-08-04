using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using wwpcbot_v2.IRC;
using System.Xml;
using System.Threading;

namespace wwpcbot_v2.API
{
    struct PlayerInfo
    {
        public string playerName;
        public string playerStream;
    }
    class GetSpeedrunInfo
    {
        public static async Task<string> GetGameID(string game)
        {
            string id = null;
            var client = new RestClient("http://www.speedrun.com/api/v1/");
            var request = new RestRequest("games?name={game}", Method.GET);
            request.AddParameter("game", game, ParameterType.UrlSegment);
            request.AddParameter("max", 1);
            var cancellationTokenSource = new CancellationTokenSource();
            var obj1 = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            var pObj1 = JObject.Parse(obj1.Content);
            id = (string)pObj1["data"][0]["id"];
            return id;
        }

        public static async Task<Tuple<string, PlayerInfo>> GetWR(string game)
        {
            string wr = null;
            var client = new RestClient("http://www.speedrun.com/api/v1/");
            var request = new RestRequest("games/{id}/records", Method.GET);
            request.AddParameter("id", GetGameID(game), ParameterType.UrlSegment);
            request.AddParameter("miscellaneous", "no");
            request.AddParameter("scope", "full-game");
            request.AddParameter("top", 1);
            request.AddParameter("skip-empty", "yes");
            request.AddParameter("max", 1);
            var cancellationTokenSource = new CancellationTokenSource();
            var obj = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            var pObj = JObject.Parse(obj.Content);
            wr = (string)pObj["data"][0]["runs"][0]["run"]["times"]["primary"];
            PlayerInfo info = new PlayerInfo();
            info = await GetPlayerInfo((string)pObj["data"][0]["runs"][0]["run"]["players"][0]["id"]);
            TimeSpan t2 = XmlConvert.ToTimeSpan(wr);
            if (wr.Contains("H"))
                wr = t2.ToString(@"h\:mm\:ss");
            else
                wr = t2.ToString(@"mm\:ss");
            return Tuple.Create(wr, info);
        }

        public static async Task<PlayerInfo> GetPlayerInfo(string id)
        {
            PlayerInfo player = new PlayerInfo();
            var client = new RestClient("http://www.speedrun.com/api/v1/");
            var request = new RestRequest("users/{id}", Method.GET);
            request.AddParameter("id", id, ParameterType.UrlSegment);
            var cancellationTokenSource = new CancellationTokenSource();
            var obj = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            var pObj = JObject.Parse(obj.Content);
            player.playerName = (string)pObj["data"]["names"]["international"];
            player.playerStream = (string)pObj["data"]["twitch"]["uri"];
            return player;
        }
    }
}
