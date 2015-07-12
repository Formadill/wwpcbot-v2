namespace wwpcbot_v2
{
    partial class AddFunc
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
            this.labelCmds = new System.Windows.Forms.Label();
            this.checkBoxCmds = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxCustomCmds = new System.Windows.Forms.CheckBox();
            this.labelTwitchCap = new System.Windows.Forms.Label();
            this.checkBoxTwitchCap = new System.Windows.Forms.CheckBox();
            this.checkBoxMember = new System.Windows.Forms.CheckBox();
            this.checkBoxTags = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelCmds
            // 
            this.labelCmds.AutoSize = true;
            this.labelCmds.Location = new System.Drawing.Point(12, 9);
            this.labelCmds.Name = "labelCmds";
            this.labelCmds.Size = new System.Drawing.Size(62, 13);
            this.labelCmds.TabIndex = 0;
            this.labelCmds.Text = "Commands:";
            // 
            // checkBoxCmds
            // 
            this.checkBoxCmds.AutoSize = true;
            this.checkBoxCmds.Location = new System.Drawing.Point(145, 8);
            this.checkBoxCmds.Name = "checkBoxCmds";
            this.checkBoxCmds.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCmds.TabIndex = 1;
            this.checkBoxCmds.UseVisualStyleBackColor = true;
            this.checkBoxCmds.CheckedChanged += new System.EventHandler(this.checkBoxCmds_CheckedChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(12, 227);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxCustomCmds
            // 
            this.checkBoxCustomCmds.AutoSize = true;
            this.checkBoxCustomCmds.Location = new System.Drawing.Point(145, 28);
            this.checkBoxCustomCmds.Name = "checkBoxCustomCmds";
            this.checkBoxCustomCmds.Size = new System.Drawing.Size(115, 17);
            this.checkBoxCustomCmds.TabIndex = 3;
            this.checkBoxCustomCmds.Text = "Custom commands";
            this.checkBoxCustomCmds.UseVisualStyleBackColor = true;
            this.checkBoxCustomCmds.Visible = false;
            // 
            // labelTwitchCap
            // 
            this.labelTwitchCap.AutoSize = true;
            this.labelTwitchCap.Location = new System.Drawing.Point(12, 114);
            this.labelTwitchCap.Name = "labelTwitchCap";
            this.labelTwitchCap.Size = new System.Drawing.Size(97, 13);
            this.labelTwitchCap.TabIndex = 4;
            this.labelTwitchCap.Text = "Twitch capabilities:";
            // 
            // checkBoxTwitchCap
            // 
            this.checkBoxTwitchCap.AutoSize = true;
            this.checkBoxTwitchCap.Location = new System.Drawing.Point(145, 113);
            this.checkBoxTwitchCap.Name = "checkBoxTwitchCap";
            this.checkBoxTwitchCap.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTwitchCap.TabIndex = 5;
            this.checkBoxTwitchCap.UseVisualStyleBackColor = true;
            this.checkBoxTwitchCap.CheckedChanged += new System.EventHandler(this.checkBoxTwitchCap_CheckedChanged);
            // 
            // checkBoxMember
            // 
            this.checkBoxMember.AutoSize = true;
            this.checkBoxMember.Location = new System.Drawing.Point(145, 133);
            this.checkBoxMember.Name = "checkBoxMember";
            this.checkBoxMember.Size = new System.Drawing.Size(83, 17);
            this.checkBoxMember.TabIndex = 6;
            this.checkBoxMember.Text = "Membership";
            this.checkBoxMember.UseVisualStyleBackColor = true;
            this.checkBoxMember.Visible = false;
            // 
            // checkBoxTags
            // 
            this.checkBoxTags.AutoSize = true;
            this.checkBoxTags.Location = new System.Drawing.Point(145, 156);
            this.checkBoxTags.Name = "checkBoxTags";
            this.checkBoxTags.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTags.TabIndex = 7;
            this.checkBoxTags.Text = "Tags";
            this.checkBoxTags.UseVisualStyleBackColor = true;
            this.checkBoxTags.Visible = false;
            // 
            // AddFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBoxTags);
            this.Controls.Add(this.checkBoxMember);
            this.Controls.Add(this.checkBoxTwitchCap);
            this.Controls.Add(this.labelTwitchCap);
            this.Controls.Add(this.checkBoxCustomCmds);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxCmds);
            this.Controls.Add(this.labelCmds);
            this.Name = "AddFunc";
            this.Text = "AddFunc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCmds;
        private System.Windows.Forms.CheckBox checkBoxCmds;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxCustomCmds;
        private System.Windows.Forms.Label labelTwitchCap;
        private System.Windows.Forms.CheckBox checkBoxTwitchCap;
        private System.Windows.Forms.CheckBox checkBoxMember;
        private System.Windows.Forms.CheckBox checkBoxTags;
    }
}