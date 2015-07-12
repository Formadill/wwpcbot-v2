namespace wwpcbot_v2.IRC
{
    partial class ConnectForm
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
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxChannel = new System.Windows.Forms.TextBox();
            this.textBoxOAuth = new System.Windows.Forms.TextBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelOAuth = new System.Windows.Forms.Label();
            this.checkBoxGroupServer = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(132, 16);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(100, 20);
            this.textBoxNick.TabIndex = 0;
            this.textBoxNick.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(132, 42);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwner.TabIndex = 1;
            this.textBoxOwner.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(132, 68);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(132, 94);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.Location = new System.Drawing.Point(132, 120);
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.Size = new System.Drawing.Size(100, 20);
            this.textBoxChannel.TabIndex = 4;
            this.textBoxChannel.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxOAuth
            // 
            this.textBoxOAuth.Location = new System.Drawing.Point(132, 146);
            this.textBoxOAuth.Name = "textBoxOAuth";
            this.textBoxOAuth.Size = new System.Drawing.Size(100, 20);
            this.textBoxOAuth.TabIndex = 5;
            this.textBoxOAuth.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Location = new System.Drawing.Point(12, 19);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(32, 13);
            this.labelNick.TabIndex = 6;
            this.labelNick.Text = "Nick:";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(12, 45);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(41, 13);
            this.labelOwner.TabIndex = 7;
            this.labelOwner.Text = "Owner:";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 71);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(20, 13);
            this.labelIP.TabIndex = 8;
            this.labelIP.Text = "IP:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 97);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 9;
            this.labelPort.Text = "Port:";
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(12, 123);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(49, 13);
            this.labelChannel.TabIndex = 10;
            this.labelChannel.Text = "Channel:";
            // 
            // labelOAuth
            // 
            this.labelOAuth.AutoSize = true;
            this.labelOAuth.Location = new System.Drawing.Point(12, 149);
            this.labelOAuth.Name = "labelOAuth";
            this.labelOAuth.Size = new System.Drawing.Size(40, 13);
            this.labelOAuth.TabIndex = 11;
            this.labelOAuth.Text = "OAuth:";
            // 
            // checkBoxGroupServer
            // 
            this.checkBoxGroupServer.AutoSize = true;
            this.checkBoxGroupServer.Location = new System.Drawing.Point(132, 182);
            this.checkBoxGroupServer.Name = "checkBoxGroupServer";
            this.checkBoxGroupServer.Size = new System.Drawing.Size(145, 17);
            this.checkBoxGroupServer.TabIndex = 12;
            this.checkBoxGroupServer.Text = "Connect to group servers";
            this.checkBoxGroupServer.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 227);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxGroupServer);
            this.Controls.Add(this.labelOAuth);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.textBoxOAuth);
            this.Controls.Add(this.textBoxChannel);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxNick);
            this.Name = "ConnectForm";
            this.Text = "ConnectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxChannel;
        private System.Windows.Forms.TextBox textBoxOAuth;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelOAuth;
        private System.Windows.Forms.CheckBox checkBoxGroupServer;
        private System.Windows.Forms.Button buttonSubmit;
    }
}