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
            this.labelCustCmds = new System.Windows.Forms.Label();
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
            // labelCustCmds
            // 
            this.labelCustCmds.AutoSize = true;
            this.labelCustCmds.Location = new System.Drawing.Point(12, 44);
            this.labelCustCmds.Name = "labelCustCmds";
            this.labelCustCmds.Size = new System.Drawing.Size(99, 13);
            this.labelCustCmds.TabIndex = 3;
            this.labelCustCmds.Text = "Custom commands:";
            // 
            // AddFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelCustCmds);
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
        private System.Windows.Forms.Label labelCustCmds;
    }
}