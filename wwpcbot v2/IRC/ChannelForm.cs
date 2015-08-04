using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            IRCconnect.MainIRC.Channel = textBox1.Text;
            Properties.Settings.Default.BotFunc = checkBox1.Checked;
            if (checkBox1.Checked)
                IRCconnect.sendData("MODE " + IRCconnect.MainIRC.BotNick + " +B\r\n");
            IRCconnect.sendData("JOIN " + IRCconnect.MainIRC.Channel + "\r\n");
            this.Close();
        }
    }
}
