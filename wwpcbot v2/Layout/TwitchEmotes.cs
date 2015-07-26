using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.Commands;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using wwpcbot_v2.IRC;
using System.Net;
using System.Drawing;
using System.Threading;

namespace wwpcbot_v2
{
    class TwitchEmotes
    {     
        public static void ReplaceEmotes()
        {
            string[] emotes = CmdControl.info.emote_sets.Split('/');
            List<string> texts = new List<string>();
            List<int> ids = new List<int>();
            int i = 0;
            foreach (string emote in emotes)
            {
                try
                {
                    int id = Convert.ToInt32(emote.Split(':')[0]);
                    Console.WriteLine(id);
                    ids.Add(id);
                    string[] placevalues = emote.Split(':')[1].Split('-');
                    texts.Add(MainForm.form.GetTextFromPos(Convert.ToInt32(placevalues[0]), Convert.ToInt32(placevalues[1])));
                    i++;
                }
                catch { Console.WriteLine("error2"); }
            }
            ReplaceEmote(texts, ids);
        }

        private static void ReplaceEmote(List<string> texts, List<int> id)
        {
            int i = 0;
            foreach (string text in texts)
            {
                string link = "http://static-cdn.jtvnw.net/emoticons/v1/" + id[i] + "/1.0";
                var request = WebRequest.Create(link);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    Image img = Bitmap.FromStream(stream);
                    MainForm.form.TextToImg(text, img);
                }
                i++;
            }
        }

        public static void bttvEmotes()
        {
            MainForm form = MainForm.form;
            var client = new RestClient("https://cdn.betterttv.net/");
            var request = new RestRequest("emotes/emotes.json", Method.GET);
            var obj = client.Execute(request);
            try
            {
                var paObj = JArray.Parse(obj.Content);

                foreach (JObject j in paObj)
                {
                    if (form.richTextBoxInput.Text.Contains((string)j["regex"]))
                    {
                        var request2 = WebRequest.Create("https:" + (string)j["url"]);
                        using (var response = request2.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            Image img = Bitmap.FromStream(stream);
                            MainForm.form.TextToImg((string)j["regex"], img);
                        }
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("timeout");
                Console.WriteLine(obj.Content);
            }
        }
    }
}
