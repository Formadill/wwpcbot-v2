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
                    output = CmdControl.info.display_name + ": " + input.Substring(input.IndexOf(IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex] + " :") + (IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex] + " :").Length);
                }
                else
                {
                    output = IRCconnect.MsgInfo.user + ": " + input.Substring(input.IndexOf(IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex] + " :") + (IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex] + " :").Length);
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
                int totalLines = form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Lines.Length;
                string lastLine = form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Lines[totalLines - 3];
                string lasterLine = form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Lines[totalLines - 2];
                int start = form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Text.IndexOf(lastLine);
                form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Select(start, CmdControl.info.display_name.Length);
                form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.SelectionColor = color;
                form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.SelectionFont = new Font(form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Font, FontStyle.Bold);
                form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Select(form.chats[MainForm.form.tabControl1.SelectedIndex].richTextBoxInput.Text.LastIndexOf(lasterLine), 0);               
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
