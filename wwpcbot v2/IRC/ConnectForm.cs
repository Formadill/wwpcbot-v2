using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wwpcbot_v2;
using wwpcbot_v2.API.OAuth2;
using wwpcbot_v2.Layout;

namespace wwpcbot_v2.IRC
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            IRCconnectInfo formOutputs;
            formOutputs.BotNick = textBoxNick.Text;
            formOutputs.BotOwner = textBoxOwner.Text;
            formOutputs.IRCip = textBoxIP.Text;
            formOutputs.IRCport = Convert.ToInt32(textBoxPort.Text);
            formOutputs.Channel = null;
            formOutputs.OAuthKey = OAuth2.GetKey();
            formOutputs.ServerName = textBoxName.Text;
            IRCconnect.MainIRC = formOutputs;
            MainForm.form.joinChannelToolStripMenuItem.Enabled = true;
            

            IRCconnect.connectMain();                        
            IRCconnect.listener();
            this.Close();
        }
    }
}
