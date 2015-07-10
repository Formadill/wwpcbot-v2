﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace wwpcbot_v2
{
    public struct IRCconnectInfo
    {
        public string IRCip;
        public int IRCport;
        public string BotNick;
        public string BotOwner;
        public string OAuthKey;
        public string Channel;
    }

    class IRCconnect
    {        
        public static bool ConnectToGroup;
        public static IRCconnectInfo MainIRC;
        public static TextReader input;
        public static TextWriter output;
        private static string __data;
        public static bool callCmdChk = false;
        public static string _data
        {
            get { return __data; }
            set {
                __data = value;
                if (callCmdChk == true)
                {
                    Functionality.CheckCmd(MainForm.form);
                }
            }
        }
        public static void connectMain(MainForm form)
        {
            //Task groupConnect = null;
            Task.Factory.StartNew(() => { new ConnectForm().ShowDialog(); }).Wait();
            TcpClient mainClient = new TcpClient();
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
            sendData("PRIVMSG " + MainIRC.Channel + " :" + msg + "\r\n");
        }
        public static async Task listener(MainForm form)
        {
            
            try
            {
                string data;
                while ((data = await input.ReadLineAsync()) != null)
                {
                    _data = data;
                    form.AddToListBox(data);
                    if(data.Split(' ')[1] == "001")
                        sendData("MODE " + IRCconnect.MainIRC.BotNick + " +B\r\n" +
                                 "JOIN " + IRCconnect.MainIRC.Channel + "\r\n");
                    if (data.StartsWith("PING ")) { sendData(data.Replace("PING", "PONG") + "\r\n");}
                }
            }
            catch (ObjectDisposedException)
            {
                // socket was closed forcefully
            }
        }

        public static void sendData(string data)
        {
            output.WriteAsync(data);
            output.FlushAsync();
        }

        public static void connectGroup()
        {
        }
    }
}