using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wwpcbot_v2;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Layout
{
    public partial class Chat : UserControl
    {
        public Chat()
        {
            InitializeComponent();
            Color color = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            richTextBoxInput.BackColor = color;
        }

        private void textBoxSendPrivMsg_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSendPrivMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IRCconnect.sendPrivMsg(textBoxSendPrivMsg.Text);
                textBoxSendPrivMsg.Text = "";
            }
        }
    }
}
