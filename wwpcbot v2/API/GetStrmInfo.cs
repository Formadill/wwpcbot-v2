using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace wwpcbot_v2.API
{
    class GetStrmInfo
    {
        public static string GetGame(string channel)
        {
            string game = null;
            var client = new RestClient("https://api.twitch.tv/kraken");
            var request = new RestRequest("/streams/{channel}", Method.GET);
            request.AddParameter("channel", channel, ParameterType.UrlSegment);
            var result = client.Execute(request);
            var pResult = JObject.Parse(result.Content);
            game = (string)pResult["stream"]["game"];
            return game;
        }
    }
}
