using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using wwpcbot_v2.Commands;
using wwpcbot_v2;

namespace wwpcbot_v2.IRC
{
    struct IRCconnectInfo
    {
        public string ServerName;
        public string IRCip;
        public int IRCport;
        public string BotNick;
        public string BotOwner;
        public string OAuthKey;
        public List<string> Channel;
    }

    class IRCconnect
    {
        
        public static bool ConnectToGroup;
        public static IRCconnectInfo MainIRC;
        public static TextReader input;
        public static TextWriter output;
        private static string __data;
        public static messageInfo MsgInfo;
        public static TcpClient mainClient = new TcpClient();
        public static string _data
        {
            get { return __data; }
            set {
                __data = value;
                MsgInfo = TwitchCap.getMessageInfo();  
                if (Properties.Settings.Default.BotFunc)
                {
                    CmdControl.CheckCmd(MainForm.form);
                }
                
            }
        }
        public static void connectMain()
        {
            MainForm form = MainForm.form;
            
            mainClient.Connect(MainIRC.IRCip, MainIRC.IRCport);
            input = new StreamReader(mainClient.GetStream());
            output = new StreamWriter(mainClient.GetStream());
            sendData(
                "PASS " + MainIRC.OAuthKey + "\r\n" +
                "NICK " + MainIRC.BotNick + "\r\n"
            );    
        }

        public static void sendPrivMsg(string msg)
        {
            sendData("PRIVMSG " + MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex] + " :" + msg + "\r\n");
        }

        public static async Task listener()
        {            
            MainForm form = MainForm.form;
            try
            {
                string data;
                while ((data = await input.ReadLineAsync()) != null)
                {
                    _data = data;
                    try
                    {
                        form.AddToListBox(data);
                    }
                    catch { }
                    if(data.Split(' ')[1] == "001" && MainIRC.IRCip == "irc.twitch.tv")
                        sendData("CAP REQ :twitch.tv/commands" + "\r\n");
                    if (data.StartsWith("PING "))
                        sendData(data.Replace("PING", "PONG") + "\r\n");                   
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        public static void sendData(string data)
        {
            Console.WriteLine(mainClient.Connected);
            output.WriteAsync(data);
            output.FlushAsync();
            try
            {
                MainForm.form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.AppendText(data.Replace(Environment.NewLine, "") + Environment.NewLine + Environment.NewLine);
            }
            catch { }
        }

        public static void connectGroup()
        {
        }
    }
}
