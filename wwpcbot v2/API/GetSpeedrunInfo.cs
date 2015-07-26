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

namespace wwpcbot_v2.API
{
    struct PlayerInfo
    {
        public string playerName;
        public string playerStream;
    }
    class GetSpeedrunInfo
    {
        public static string GetGameID(string game)
        {
            string id = null;
            var client = new RestClient("http://www.speedrun.com/api/v1/");
            var request = new RestRequest("games?name={game}", Method.GET);
            request.AddParameter("game", game, ParameterType.UrlSegment);
            request.AddParameter("max", 1);
            var obj1 = client.Execute(request);
            var pObj1 = JObject.Parse(obj1.Content);
            var paObj1 = JArray.Parse((string)pObj1["data"].ToString());
            foreach (JObject a in paObj1)
            {
                id = (string)a["id"];
            }
            return id;
        }

        public static Tuple<string, PlayerInfo> GetWR(string game)
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
            var obj = client.Execute(request);
            var pObj = JObject.Parse(obj.Content);
            var paObj = JArray.Parse((string)pObj["data"].ToString());
            JArray pObj2 = null;
            foreach (JObject a in paObj)
            {
                pObj2 = JArray.Parse((string)a["runs"].ToString());
            }
            JObject pObj3 = null;
            foreach (JObject a in pObj2)
            {
                pObj3 = (JObject)a["run"];
            }
            wr = (string)pObj3["times"]["primary"];
            var playerArray = JArray.Parse((string)pObj3["players"].ToString());
            PlayerInfo info = new PlayerInfo();
            foreach (JObject a in playerArray)
            {
                info = GetPlayerInfo((string)a["id"]);
            }
            TimeSpan t2 = XmlConvert.ToTimeSpan(wr);
            if (wr.Contains("H"))
                wr = t2.ToString(@"h\:mm\:ss");
            else
                wr = t2.ToString(@"mm\:ss");
            return Tuple.Create(wr, info);
        }

        public static PlayerInfo GetPlayerInfo(string id)
        {
            PlayerInfo player = new PlayerInfo();
            var client = new RestClient("http://www.speedrun.com/api/v1/");
            var request = new RestRequest("users/{id}", Method.GET);
            request.AddParameter("id", id, ParameterType.UrlSegment);
            var obj = client.Execute(request);
            var pObj = JObject.Parse(obj.Content);
            player.playerName = (string)pObj["data"]["names"]["international"];
            player.playerStream = (string)pObj["data"]["twitch"]["uri"];
            return player;
        }
    }
}
