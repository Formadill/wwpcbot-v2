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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBot = new System.Windows.Forms.ToolStripMenuItem();
            this.customCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedrunCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchStreamInfoCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchChatLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchEmotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTTVEmotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSendPrivMsg
            // 
            this.textBoxSendPrivMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSendPrivMsg.Location = new System.Drawing.Point(18, 769);
            this.textBoxSendPrivMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSendPrivMsg.Name = "textBoxSendPrivMsg";
            this.textBoxSendPrivMsg.Size = new System.Drawing.Size(1135, 26);
            this.textBoxSendPrivMsg.TabIndex = 2;
            this.textBoxSendPrivMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendPrivMsg_KeyDown);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(18, 51);
            this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(1135, 712);
            this.richTextBoxInput.TabIndex = 4;
            this.richTextBoxInput.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1173, 35);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnect,
            this.joinChannelToolStripMenuItem,
            this.ToolStripMenuItemBot,
            this.ToolStripMenuItemTwitch,
            this.getKeyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ToolStripMenuItemConnect
            // 
            this.ToolStripMenuItemConnect.Name = "ToolStripMenuItemConnect";
            this.ToolStripMenuItemConnect.Size = new System.Drawing.Size(236, 30);
            this.ToolStripMenuItemConnect.Text = "Connect to server";
            this.ToolStripMenuItemConnect.Click += new System.EventHandler(this.ToolStripMenuItemConnect_Click);
            // 
            // ToolStripMenuItemBot
            // 
            this.ToolStripMenuItemBot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customCommandsToolStripMenuItem,
            this.speedrunCommandsToolStripMenuItem,
            this.twitchStreamInfoCommandsToolStripMenuItem});
            this.ToolStripMenuItemBot.Name = "ToolStripMenuItemBot";
            this.ToolStripMenuItemBot.Size = new System.Drawing.Size(226, 30);
            this.ToolStripMenuItemBot.Text = "Bot functionality";
            this.ToolStripMenuItemBot.Click += new System.EventHandler(this.ToolStripMenuItemBot_Click);
            // 
            // customCommandsToolStripMenuItem
            // 
            this.customCommandsToolStripMenuItem.Name = "customCommandsToolStripMenuItem";
            this.customCommandsToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.customCommandsToolStripMenuItem.Text = "Custom commands";
            this.customCommandsToolStripMenuItem.Click += new System.EventHandler(this.customCommandsToolStripMenuItem_Click);
            // 
            // speedrunCommandsToolStripMenuItem
            // 
            this.speedrunCommandsToolStripMenuItem.Name = "speedrunCommandsToolStripMenuItem";
            this.speedrunCommandsToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.speedrunCommandsToolStripMenuItem.Text = "Speedrun commands";
            this.speedrunCommandsToolStripMenuItem.Click += new System.EventHandler(this.speedrunCommandsToolStripMenuItem_Click);
            // 
            // twitchStreamInfoCommandsToolStripMenuItem
            // 
            this.twitchStreamInfoCommandsToolStripMenuItem.Name = "twitchStreamInfoCommandsToolStripMenuItem";
            this.twitchStreamInfoCommandsToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.twitchStreamInfoCommandsToolStripMenuItem.Text = "Twitch stream info commands";
            this.twitchStreamInfoCommandsToolStripMenuItem.Click += new System.EventHandler(this.twitchStreamInfoCommandsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemTwitch
            // 
            this.ToolStripMenuItemTwitch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitchChatLayoutToolStripMenuItem,
            this.twitchEmotesToolStripMenuItem,
            this.bTTVEmotesToolStripMenuItem});
            this.ToolStripMenuItemTwitch.Name = "ToolStripMenuItemTwitch";
            this.ToolStripMenuItemTwitch.Size = new System.Drawing.Size(226, 30);
            this.ToolStripMenuItemTwitch.Text = "Layout";
            // 
            // twitchChatLayoutToolStripMenuItem
            // 
            this.twitchChatLayoutToolStripMenuItem.Name = "twitchChatLayoutToolStripMenuItem";
            this.twitchChatLayoutToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.twitchChatLayoutToolStripMenuItem.Text = "Twitch chat layout";
            this.twitchChatLayoutToolStripMenuItem.Click += new System.EventHandler(this.twitchChatLayoutToolStripMenuItem_Click);
            // 
            // twitchEmotesToolStripMenuItem
            // 
            this.twitchEmotesToolStripMenuItem.Name = "twitchEmotesToolStripMenuItem";
            this.twitchEmotesToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.twitchEmotesToolStripMenuItem.Text = "Twitch emotes";
            this.twitchEmotesToolStripMenuItem.Click += new System.EventHandler(this.twitchEmotesToolStripMenuItem_Click);
            // 
            // bTTVEmotesToolStripMenuItem
            // 
            this.bTTVEmotesToolStripMenuItem.Name = "bTTVEmotesToolStripMenuItem";
            this.bTTVEmotesToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.bTTVEmotesToolStripMenuItem.Text = "BTTV emotes";
            this.bTTVEmotesToolStripMenuItem.Click += new System.EventHandler(this.bTTVEmotesToolStripMenuItem_Click);
            // 
            // getKeyToolStripMenuItem
            // 
            this.getKeyToolStripMenuItem.Name = "getKeyToolStripMenuItem";
            this.getKeyToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.getKeyToolStripMenuItem.Text = "GetKey";
            this.getKeyToolStripMenuItem.Click += new System.EventHandler(this.getKeyToolStripMenuItem_Click);
            // 
            // joinChannelToolStripMenuItem
            // 
            this.joinChannelToolStripMenuItem.Name = "joinChannelToolStripMenuItem";
            this.joinChannelToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.joinChannelToolStripMenuItem.Text = "Join Channel";
            this.joinChannelToolStripMenuItem.Click += new System.EventHandler(this.joinChannelToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 832);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.textBoxSendPrivMsg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        public System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBot;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTwitch;
        private System.Windows.Forms.ToolStripMenuItem twitchChatLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitchEmotesToolStripMenuItem;
        private ToolStripMenuItem customCommandsToolStripMenuItem;
        private ToolStripMenuItem speedrunCommandsToolStripMenuItem;
        private ToolStripMenuItem twitchStreamInfoCommandsToolStripMenuItem;
        private ToolStripMenuItem bTTVEmotesToolStripMenuItem;
        private ToolStripMenuItem getKeyToolStripMenuItem;
        private ToolStripMenuItem joinChannelToolStripMenuItem;
    }
}

