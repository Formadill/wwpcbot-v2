using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace wwpcbot_v2.API
{
    class GetStrmInfo
    {
        public static async Task<string> GetGame(string channel)
        {
            string game = null;
            var client = new RestClient("https://api.twitch.tv/kraken");
            var request = new RestRequest("/streams/{channel}", Method.GET);
            request.AddParameter("channel", channel, ParameterType.UrlSegment);
            var cancellationTokenSource = new CancellationTokenSource();
            var result = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            var pResult = JObject.Parse(result.Content);
            game = (string)pResult["stream"]["game"];
            return game;
        }
    }
}
