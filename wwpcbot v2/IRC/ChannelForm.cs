using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wwpcbot_v2.Layout;

namespace wwpcbot_v2.IRC
{
    public partial class ChannelForm : Form
    {
        public ChannelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IRCconnect.MainIRC.Channel == null)
                IRCconnect.MainIRC.Channel = new List<string>();
            IRCconnect.MainIRC.Channel.Add(textBox1.Text);
            Properties.Settings.Default.BotFunc = checkBox1.Checked;
            MainForm.form.ToolStripMenuItemBot.Enabled = checkBox1.Checked;
            MainForm.form.ToolStripMenuItemLayout.Enabled = true;
            if (IRCconnect.MainIRC.IRCip == "irc.twitch.tv")
                MainForm.form.twitchLayoutToolStripMenuItem.Enabled = true;
            Chat chat = new Chat();
            chat.Dock = DockStyle.Fill;
            MainForm.form.chats.Add(chat);
            TabPage tab = new TabPage();
            tab.Controls.Add(chat);
            tab.Text = textBox1.Text;
            MainForm.form.tabs.Add(tab);            
            MainForm.form.tabControl1.TabPages.Add(tab);
            if (checkBox1.Checked)
                IRCconnect.sendData("MODE " + IRCconnect.MainIRC.BotNick + " +B\r\n");
            IRCconnect.sendData("JOIN " + textBox1.Text + "\r\n");

            this.Close();
        }
    }
}
