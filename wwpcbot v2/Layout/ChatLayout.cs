﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.Functionalities;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Layout
{
    class ChatLayout
    {
        public static string removeIRCtext(string input)
        {
            string output = input;
            if (input.Contains("PRIVMSG"))
            {
                if (Properties.Settings.Default.TwitchLayout)
                {
                    output = Functionality.info.display_name + ": " + input.Substring(input.IndexOf(IRCconnect.MainIRC.Channel + " :") + (IRCconnect.MainIRC.Channel + " :").Length);
                }
                else
                {
                    output = IRCconnect.MsgInfo.user + ": " + input.Substring(input.IndexOf(IRCconnect.MainIRC.Channel + " :") + (IRCconnect.MainIRC.Channel + " :").Length);
                }
            }
            return output;
        }

        public static void addToChatLayout()
        {
            MainForm form = MainForm.form;
            if (Functionality.TagBool == true && Functionality.info.display_name != null)
            {
                Color color = ColorTranslator.FromHtml(Functionality.info.color);
                int totalLines = form.richTextBoxInput.Lines.Length;
                string lastLine = form.richTextBoxInput.Lines[totalLines - 3];
                string lasterLine = form.richTextBoxInput.Lines[totalLines - 2];
                int start = form.richTextBoxInput.Text.IndexOf(lastLine);
                form.richTextBoxInput.Select(start, Functionality.info.display_name.Length);
                form.richTextBoxInput.SelectionColor = color;
                form.richTextBoxInput.SelectionFont = new Font(form.richTextBoxInput.Font, FontStyle.Bold);
                form.richTextBoxInput.Select(form.richTextBoxInput.Text.LastIndexOf(lasterLine), 0);
                if (Functionality.info.emote_sets != "" && IRCconnect._data.Contains("PRIVMSG"))
                {
                    Functionality.replaceEmotes();
                }
            }
        }
    }
}
