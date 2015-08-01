using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wwpcbot_v2.API.OAuth2
{
    public partial class GetKeyForm : Form
    {
        
        public GetKeyForm()
        {
            InitializeComponent();     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string url = null;
            if (webBrowser1.Url != null)
                if (webBrowser1.Url.ToString().Contains("#access_token"))
                {
                    webBrowser1.Visible = false;
                    url = webBrowser1.Url.ToString().Substring(webBrowser1.Url.ToString().IndexOf("#"));
                    url = url.Substring(0, url.IndexOf("&"));
                    url = url.Substring(url.IndexOf("=") + 1);
                    url = "oauth:" + url;
                    OAuth2.Key = url;
                    this.Close();
                }
        }

        private void GetKeyForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.twitch.tv/logout");
        }

        private void webBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (!webBrowser1.Url.ToString().Contains("https://api.twitch.tv/kraken/oauth2/"))
            {
                webBrowser1.Navigate("https://api.twitch.tv/kraken/oauth2/authorize?response_type=token&amp;client_id=4gc4im1o2rtf0l45ejiyf68xej77qwe&amp;redirect_uri=http://twitchapps.com/tmi/&amp;scope=chat_login");
                timer1.Start();
            }
            else
            {
                webBrowser1.Visible = true;
            }
        }

    }
}
