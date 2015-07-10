using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            listBoxOutput.Items.Add(addString);

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
    }
}
