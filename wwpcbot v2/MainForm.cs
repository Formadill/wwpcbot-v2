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
using System.Globalization;

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
            if (Functionality.TagBool == true)
                addString = Functionality.info.display_name + ": " + addString.Substring(addString.IndexOf(IRCconnect.MainIRC.Channel + " :") + (IRCconnect.MainIRC.Channel + " :").Length);
            richTextBoxInput.AppendText(addString + Environment.NewLine + Environment.NewLine);
            if (Functionality.TagBool == true && Functionality.info.display_name != null)
            {
                Color color = System.Drawing.ColorTranslator.FromHtml(Functionality.info.color);
                int totalLines = richTextBoxInput.Lines.Length;
                string lastLine = richTextBoxInput.Lines[totalLines - 3];
                string lasterLine = richTextBoxInput.Lines[totalLines - 2];
                int start = richTextBoxInput.Text.IndexOf(lastLine);
                Console.WriteLine(start);
                richTextBoxInput.Select(start, Functionality.info.display_name.Length);
                richTextBoxInput.SelectionColor = color;
                richTextBoxInput.SelectionFont = new Font(richTextBoxInput.Font, FontStyle.Bold);
                richTextBoxInput.Select(richTextBoxInput.Text.LastIndexOf(lasterLine), 0);
                if (Functionality.info.emote_sets != "" && IRCconnect._data.Contains("PRIVMSG"))
                {
                    Functionality.replaceEmotes();
                }
            }

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

        private void buttonFunc_Click(object sender, EventArgs e)
        {
            Functionality.ActivateFunc(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            richTextBoxInput.Enabled = true;
            richTextBoxInput.BackColor = color;
        }

        public string GetTextFromPos(int start, int end)
        {
            string text = null;
            int totalLines = richTextBoxInput.Lines.Length;
            string lastLine = richTextBoxInput.Lines[totalLines - 3];
            lastLine = lastLine.Substring(lastLine.IndexOf(":") + 2);
            Console.WriteLine(lastLine);
            Console.WriteLine(start);
            Console.WriteLine(end);
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
            Functionality.CapBool = true;
            Functionality.TagBool = true;
            Functionality.ActivateFunc(this);       
        }
    }
}
