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
using wwpcbot_v2.Functionalities;
using wwpcbot_v2.IRC;

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

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(() => IRCconnect.connectMain(this),CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            IRCconnect.connectMain(this);
            IRCconnect.listener(this);           
        }
        public void AddToListBox(string addString)
        {
            richTextBoxInput.AppendText(addString + Environment.NewLine);
        }

        public void TextToImg(string text, Image img)
        {
            int index;
            if ((index = richTextBoxInput.Find(text)) > -1)
            {
                richTextBoxInput.Select(index, text.Length);
                Clipboard.SetImage(img);
                richTextBoxInput.Paste();
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

        private void buttonFunc_Click(object sender, EventArgs e)
        {
            Functionality.ActivateFunc(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            richTextBoxInput.Enabled = true;
        }
    }
}
