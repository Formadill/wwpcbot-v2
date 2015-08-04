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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.joinChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBot = new System.Windows.Forms.ToolStripMenuItem();
            this.customCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedrunCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchStreamInfoCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchChatLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchEmotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTTVEmotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnect,
            this.joinChannelToolStripMenuItem,
            this.ToolStripMenuItemBot,
            this.ToolStripMenuItemLayout});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ToolStripMenuItemConnect
            // 
            this.ToolStripMenuItemConnect.Name = "ToolStripMenuItemConnect";
            this.ToolStripMenuItemConnect.Size = new System.Drawing.Size(167, 22);
            this.ToolStripMenuItemConnect.Text = "Connect to server";
            this.ToolStripMenuItemConnect.Click += new System.EventHandler(this.ToolStripMenuItemConnect_Click);
            // 
            // joinChannelToolStripMenuItem
            // 
            this.joinChannelToolStripMenuItem.Enabled = false;
            this.joinChannelToolStripMenuItem.Name = "joinChannelToolStripMenuItem";
            this.joinChannelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.joinChannelToolStripMenuItem.Text = "Join Channel";
            this.joinChannelToolStripMenuItem.Click += new System.EventHandler(this.joinChannelToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemBot
            // 
            this.ToolStripMenuItemBot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customCommandsToolStripMenuItem,
            this.speedrunCommandsToolStripMenuItem,
            this.twitchStreamInfoCommandsToolStripMenuItem});
            this.ToolStripMenuItemBot.Enabled = false;
            this.ToolStripMenuItemBot.Name = "ToolStripMenuItemBot";
            this.ToolStripMenuItemBot.Size = new System.Drawing.Size(167, 22);
            this.ToolStripMenuItemBot.Text = "Bot functionality";
            this.ToolStripMenuItemBot.Click += new System.EventHandler(this.ToolStripMenuItemBot_Click);
            // 
            // customCommandsToolStripMenuItem
            // 
            this.customCommandsToolStripMenuItem.Name = "customCommandsToolStripMenuItem";
            this.customCommandsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.customCommandsToolStripMenuItem.Text = "Custom commands";
            this.customCommandsToolStripMenuItem.Click += new System.EventHandler(this.customCommandsToolStripMenuItem_Click);
            // 
            // speedrunCommandsToolStripMenuItem
            // 
            this.speedrunCommandsToolStripMenuItem.Name = "speedrunCommandsToolStripMenuItem";
            this.speedrunCommandsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.speedrunCommandsToolStripMenuItem.Text = "Speedrun commands";
            this.speedrunCommandsToolStripMenuItem.Click += new System.EventHandler(this.speedrunCommandsToolStripMenuItem_Click);
            // 
            // twitchStreamInfoCommandsToolStripMenuItem
            // 
            this.twitchStreamInfoCommandsToolStripMenuItem.Name = "twitchStreamInfoCommandsToolStripMenuItem";
            this.twitchStreamInfoCommandsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.twitchStreamInfoCommandsToolStripMenuItem.Text = "Twitch stream info commands";
            this.twitchStreamInfoCommandsToolStripMenuItem.Click += new System.EventHandler(this.twitchStreamInfoCommandsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemLayout
            // 
            this.ToolStripMenuItemLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitchLayoutToolStripMenuItem});
            this.ToolStripMenuItemLayout.Enabled = false;
            this.ToolStripMenuItemLayout.Name = "ToolStripMenuItemLayout";
            this.ToolStripMenuItemLayout.Size = new System.Drawing.Size(167, 22);
            this.ToolStripMenuItemLayout.Text = "Layout";
            // 
            // twitchLayoutToolStripMenuItem
            // 
            this.twitchLayoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitchChatLayoutToolStripMenuItem,
            this.twitchEmotesToolStripMenuItem,
            this.bTTVEmotesToolStripMenuItem});
            this.twitchLayoutToolStripMenuItem.Enabled = false;
            this.twitchLayoutToolStripMenuItem.Name = "twitchLayoutToolStripMenuItem";
            this.twitchLayoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twitchLayoutToolStripMenuItem.Text = "Twitch layout";
            // 
            // twitchChatLayoutToolStripMenuItem
            // 
            this.twitchChatLayoutToolStripMenuItem.Name = "twitchChatLayoutToolStripMenuItem";
            this.twitchChatLayoutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.twitchChatLayoutToolStripMenuItem.Text = "Twitch chat layout";
            this.twitchChatLayoutToolStripMenuItem.Click += new System.EventHandler(this.twitchChatLayoutToolStripMenuItem_Click);
            // 
            // twitchEmotesToolStripMenuItem
            // 
            this.twitchEmotesToolStripMenuItem.Name = "twitchEmotesToolStripMenuItem";
            this.twitchEmotesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.twitchEmotesToolStripMenuItem.Text = "Twitch emotes";
            this.twitchEmotesToolStripMenuItem.Click += new System.EventHandler(this.twitchEmotesToolStripMenuItem_Click);
            // 
            // bTTVEmotesToolStripMenuItem
            // 
            this.bTTVEmotesToolStripMenuItem.Name = "bTTVEmotesToolStripMenuItem";
            this.bTTVEmotesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bTTVEmotesToolStripMenuItem.Text = "BTTV emotes";
            this.bTTVEmotesToolStripMenuItem.Click += new System.EventHandler(this.bTTVEmotesToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 530);
            this.tabControl1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 569);
            this.Controls.Add(this.tabControl1);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnect;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBot;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLayout;
        private ToolStripMenuItem customCommandsToolStripMenuItem;
        private ToolStripMenuItem speedrunCommandsToolStripMenuItem;
        private ToolStripMenuItem twitchStreamInfoCommandsToolStripMenuItem;
        public ToolStripMenuItem joinChannelToolStripMenuItem;
        public TabControl tabControl1;
        public ToolStripMenuItem twitchLayoutToolStripMenuItem;
        private ToolStripMenuItem twitchChatLayoutToolStripMenuItem;
        private ToolStripMenuItem twitchEmotesToolStripMenuItem;
        private ToolStripMenuItem bTTVEmotesToolStripMenuItem;
    }
}

