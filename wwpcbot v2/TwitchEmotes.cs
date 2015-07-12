using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.Functionalities;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using wwpcbot_v2.IRC;
using System.Net;
using System.Drawing;

namespace wwpcbot_v2
{
    class TwitchEmotes
    {     
        public static void ReplaceEmotes()
        {
            string[] emotes = Functionality.info.emote_sets.Split('/');
            List<string> texts = new List<string>();
            List<int> ids = new List<int>();
            int i = 0;
            foreach (string emote in emotes)
            {
                int id = Convert.ToInt32(emote.Split(':')[0]);
                Console.WriteLine(id);
                ids.Add(id);
                string[] placevalues = emote.Split(':')[1].Split('-');
                texts.Add(MainForm.form.GetTextFromPos(Convert.ToInt32(placevalues[0]), Convert.ToInt32(placevalues[1]) + 1));
                i++;
            }
            ReplaceEmote(texts, ids);
        }

        public static void ReplaceEmote(List<string> texts, List<int> id)
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
    }
}
