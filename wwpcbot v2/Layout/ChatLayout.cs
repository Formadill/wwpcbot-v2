using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.Commands;
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
                    output = CmdControl.info.display_name + ": " + input.Substring(input.IndexOf(IRCconnect.MainIRC.Channel + " :") + (IRCconnect.MainIRC.Channel + " :").Length);
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
            if (Properties.Settings.Default.TwitchLayout == true && CmdControl.info.display_name != null && IRCconnect._data.Contains("PRIVMSG"))
            {
                
                Color color = ColorTranslator.FromHtml(CmdControl.info.color);
                int totalLines = form.richTextBoxInput.Lines.Length;
                string lastLine = form.richTextBoxInput.Lines[totalLines - 3];
                string lasterLine = form.richTextBoxInput.Lines[totalLines - 2];
                int start = form.richTextBoxInput.Text.IndexOf(lastLine);
                form.richTextBoxInput.Select(start, CmdControl.info.display_name.Length);
                form.richTextBoxInput.SelectionColor = color;
                form.richTextBoxInput.SelectionFont = new Font(form.richTextBoxInput.Font, FontStyle.Bold);
                form.richTextBoxInput.Select(form.richTextBoxInput.Text.LastIndexOf(lasterLine), 0);               
            }
            if (Properties.Settings.Default.TwitchEmotes == true && CmdControl.info.emote_sets.Contains(':'))
            {
                CmdControl.replaceEmotes();
            }
            if (Properties.Settings.Default.BTTVEmotes == true)
            {
                TwitchEmotes.bttvEmotes();
            }
        }
    }
}
