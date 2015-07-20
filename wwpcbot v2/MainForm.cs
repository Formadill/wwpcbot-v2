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

namespace wwpcbot_v2
{
    public partial class MainForm : Form
    {
        public static MainForm form;
        public MainForm()
        {
            InitializeComponent();
            form = this;
        }

        public void AddToListBox(string addString)
        {
            addString = ChatLayout.removeIRCtext(addString);
            richTextBoxInput.AppendText(addString + Environment.NewLine + Environment.NewLine);
            ChatLayout.addToChatLayout();
        }

        public void TextToImg(string text, Image img)
        {
            int index;
            while (richTextBoxInput.Text.Contains(text))
            {
                if ((index = richTextBoxInput.Find(text)) > -1)
                {
                    richTextBoxInput.Select(index, text.Length);
                    Clipboard.SetImage(img);
                    richTextBoxInput.Paste();
                }
            }
        }

        private void textBoxSendPrivMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IRCconnect.sendPrivMsg(textBoxSendPrivMsg.Text);
                textBoxSendPrivMsg.Text = "";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            richTextBoxInput.BackColor = color;
        }

        public string GetTextFromPos(int start, int end)
        {
            string text = null;
            int totalLines = richTextBoxInput.Lines.Length;
            string lastLine = richTextBoxInput.Lines[totalLines - 3];
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
            Properties.Settings.Default.BotFunc = true;
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
    }
}
