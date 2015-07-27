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
            info.title = (string)pObj["items"][0]["snippet"]["title"];
            info.creator = (string)pObj["items"][0]["snippet"]["channelTitle"];
            info.views = (int)pObj["items"][0]["statistics"]["viewCount"];
            info.likes = (int)pObj["items"][0]["statistics"]["likeCount"];
            info.dislikes = (int)pObj["items"][0]["statistics"]["dislikeCount"];
            return info;
        }
    }
}
