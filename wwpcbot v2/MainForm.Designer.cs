using System.Windows.Forms;
namespace wwpcbot_v2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSendPrivMsg = new System.Windows.Forms.TextBox();
            this.buttonFunc = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBot = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchChatLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchEmotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSendPrivMsg
            // 
            this.textBoxSendPrivMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSendPrivMsg.Location = new System.Drawing.Point(12, 429);
            this.textBoxSendPrivMsg.Name = "textBoxSendPrivMsg";
            this.textBoxSendPrivMsg.Size = new System.Drawing.Size(508, 20);
            this.textBoxSendPrivMsg.TabIndex = 2;
            this.textBoxSendPrivMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendPrivMsg_KeyDown);
            // 
            // buttonFunc
            // 
            this.buttonFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFunc.Location = new System.Drawing.Point(526, 33);
            this.buttonFunc.Name = "buttonFunc";
            this.buttonFunc.Size = new System.Drawing.Size(75, 23);
            this.buttonFunc.TabIndex = 3;
            this.buttonFunc.Text = "Functionality";
            this.buttonFunc.UseVisualStyleBackColor = true;
            this.buttonFunc.Click += new System.EventHandler(this.buttonFunc_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 33);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(508, 393);
            this.richTextBoxInput.TabIndex = 4;
            this.richTextBoxInput.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnect,
            this.ToolStripMenuItemBot,
            this.ToolStripMenuItemTwitch,
            this.twitchTagsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ToolStripMenuItemConnect
            // 
            this.ToolStripMenuItemConnect.Name = "ToolStripMenuItemConnect";
            this.ToolStripMenuItemConnect.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItemConnect.Text = "Connect";
            this.ToolStripMenuItemConnect.Click += new System.EventHandler(this.ToolStripMenuItemConnect_Click);
            // 
            // ToolStripMenuItemBot
            // 
            this.ToolStripMenuItemBot.Name = "ToolStripMenuItemBot";
            this.ToolStripMenuItemBot.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItemBot.Text = "Bot functionality";
            this.ToolStripMenuItemBot.Click += new System.EventHandler(this.ToolStripMenuItemBot_Click);
            // 
            // ToolStripMenuItemTwitch
            // 
            this.ToolStripMenuItemTwitch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitchChatLayoutToolStripMenuItem,
            this.twitchEmotesToolStripMenuItem});
            this.ToolStripMenuItemTwitch.Name = "ToolStripMenuItemTwitch";
            this.ToolStripMenuItemTwitch.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItemTwitch.Text = "Twitch integration";
            // 
            // twitchChatLayoutToolStripMenuItem
            // 
            this.twitchChatLayoutToolStripMenuItem.Name = "twitchChatLayoutToolStripMenuItem";
            this.twitchChatLayoutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.twitchChatLayoutToolStripMenuItem.Text = "Twitch chat layout";
            this.twitchChatLayoutToolStripMenuItem.Click += new System.EventHandler(this.twitchChatLayoutToolStripMenuItem_Click);
            // 
            // twitchEmotesToolStripMenuItem
            // 
            this.twitchEmotesToolStripMenuItem.Name = "twitchEmotesToolStripMenuItem";
            this.twitchEmotesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.twitchEmotesToolStripMenuItem.Text = "Twitch emotes";
            // 
            // twitchTagsToolStripMenuItem
            // 
            this.twitchTagsToolStripMenuItem.Name = "twitchTagsToolStripMenuItem";
            this.twitchTagsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.twitchTagsToolStripMenuItem.Text = "Twitch Tags";
            this.twitchTagsToolStripMenuItem.Click += new System.EventHandler(this.twitchTagsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 470);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.buttonFunc);
            this.Controls.Add(this.textBoxSendPrivMsg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "wwpcbot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSendPrivMsg;
        private System.Windows.Forms.Button buttonFunc;
        public System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBot;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTwitch;
        private System.Windows.Forms.ToolStripMenuItem twitchTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitchChatLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitchEmotesToolStripMenuItem;
    }
}

