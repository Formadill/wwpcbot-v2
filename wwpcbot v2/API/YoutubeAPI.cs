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
    struct videoInfo
    {
        public string title;
        public string creator;
        public int views;
        public int likes;
        public int dislikes;        
    }
    class YoutubeAPI
    {
        public static videoInfo GetVideoInfo(string id)
        {
            videoInfo info = new videoInfo();
            var client = new RestClient("https://www.googleapis.com/youtube/v3/");
            var request = new RestRequest("videos?id={id}", Method.GET);
            request.AddParameter("id", id, ParameterType.UrlSegment);
            request.AddParameter("part", "snippet,statistics");
            request.AddParameter("key", Properties.Settings.Default.YoutubeAPIkey);
            var obj = client.Execute(request);
            var pObj = JToken.Parse(obj.Content);
            var paObj = JArray.Parse((string)pObj["items"].ToString());
            foreach (JObject j in paObj)
            {
                info.title = (string)j["snippet"]["title"];
                info.creator = (string)j["snippet"]["channelTitle"];
                info.views = (int)j["statistics"]["viewCount"];
                info.likes = (int)j["statistics"]["likeCount"];
                info.likes = (int)j["statistics"]["dislikeCount"];
            }
            return info;
        }
    }
}
