using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wwpcbot_v2;
using wwpcbot_v2.Commands;
using wwpcbot_v2.IRC;
using System.Globalization;
using wwpcbot_v2.Layout;
using wwpcbot_v2.API.OAuth2;

namespace wwpcbot_v2
{
    public partial class MainForm : Form
    {
        public List<Chat> chats = new List<Chat>();
        public List<TabPage> tabs = new List<TabPage>();
        public static MainForm form;
        public MainForm()
        {
            InitializeComponent();
            form = this;
        }

        public void AddToListBox(string addString)
        {
            if (IRCconnect.MainIRC.Channel[tabControl1.SelectedIndex] == IRCconnect.MsgInfo.channel)
            {
                Console.WriteLine(tabControl1.SelectedIndex);
                addString = ChatLayout.removeIRCtext(addString);
                chats[tabControl1.SelectedIndex].richTextBoxInput.AppendText(addString + Environment.NewLine + Environment.NewLine);
                Task.Factory.StartNew(ChatLayout.addToChatLayout, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        public void TextToImg(string text, Image img)
        {
            int index;
            while (chats[tabControl1.SelectedIndex].richTextBoxInput.Text.Contains(text))
            {
                if ((index = chats[tabControl1.SelectedIndex].richTextBoxInput.Find(text)) > -1)
                {
                    chats[tabControl1.SelectedIndex].richTextBoxInput.Select(index, text.Length);
                    Clipboard.SetImage(img);
                    chats[tabControl1.SelectedIndex].richTextBoxInput.Paste();
                }
            }
        }

        private void textBoxSendPrivMsg_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            chats.Add(new Chat());
            chats[0].Dock = DockStyle.Fill;
            tabs.Add(new TabPage());
            tabs[0].Controls.Add(chats[0]);
            tabControl1.TabPages.Add(tabs[0]);
            */
        }

        public string GetTextFromPos(int start, int end)
        {
            string text = null;
            int totalLines = chats[tabControl1.SelectedIndex].richTextBoxInput.Lines.Length;
            string lastLine = chats[tabControl1.SelectedIndex].richTextBoxInput.Lines[totalLines - 3];
            lastLine = lastLine.Substring(lastLine.IndexOf(IRCconnect.MsgInfo.user + ": ") + (IRCconnect.MsgInfo.user + ": ").Length);
            text = lastLine.Substring(0, end + 1).Substring(start);
            return text;
        }

        private void ToolStripMenuItemConnect_Click(object sender, EventArgs e)
        {
            ConnectForm conForm = new ConnectForm();
            conForm.Show();
        }

        private void twitchTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  
        }

        private void twitchChatLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!twitchChatLayoutToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.TwitchLayout = true;
                twitchChatLayoutToolStripMenuItem.Checked = true;
                TwitchCap.ackTag();
            }
            else
            {
                Properties.Settings.Default.TwitchLayout = false;
                twitchChatLayoutToolStripMenuItem.Checked = false;
            }
        }

        private void ToolStripMenuItemBot_Click(object sender, EventArgs e)
        {
            
        }

        private void twitchEmotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!twitchEmotesToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.TwitchEmotes = true;
                twitchEmotesToolStripMenuItem.Checked = true;
                TwitchCap.ackTag();
            }
            else
            {
                Properties.Settings.Default.TwitchEmotes = false;
                twitchEmotesToolStripMenuItem.Checked = false;
            }
        }

        private void customCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!customCommandsToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.CustomCmds = true;
                customCommandsToolStripMenuItem.Checked = true;
            }
            else
            {
                Properties.Settings.Default.CustomCmds = false;
                customCommandsToolStripMenuItem.Checked = false;
            }
        }

        private void speedrunCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!speedrunCommandsToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.SpeedrunCmds = true;
                speedrunCommandsToolStripMenuItem.Checked = true;
            }
            else
            {
                Properties.Settings.Default.SpeedrunCmds = false;
                speedrunCommandsToolStripMenuItem.Checked = false;
            }
        }

        private void twitchStreamInfoCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!twitchStreamInfoCommandsToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.TwitchInfoCmds = true;
                twitchStreamInfoCommandsToolStripMenuItem.Checked = true;
            }
            else
            {
                Properties.Settings.Default.TwitchInfoCmds = false;
                twitchStreamInfoCommandsToolStripMenuItem.Checked = false;
            }
        }

        private void bTTVEmotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!bTTVEmotesToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.BTTVEmotes = true;
                bTTVEmotesToolStripMenuItem.Checked = true;
            }
            else
            {
                Properties.Settings.Default.BTTVEmotes = false;
                bTTVEmotesToolStripMenuItem.Checked = false;
            }
        }

        private void getKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(OAuth2.GetKey());
        }

        private void joinChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChannelForm form = new ChannelForm();
            form.Show();
        }
    }
}
