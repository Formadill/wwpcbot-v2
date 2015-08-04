namespace wwpcbot_v2.Layout
{
    partial class Chat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxSendPrivMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(843, 480);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // textBoxSendPrivMsg
            // 
            this.textBoxSendPrivMsg.Location = new System.Drawing.Point(3, 483);
            this.textBoxSendPrivMsg.Name = "textBoxSendPrivMsg";
            this.textBoxSendPrivMsg.Size = new System.Drawing.Size(837, 20);
            this.textBoxSendPrivMsg.TabIndex = 1;
            this.textBoxSendPrivMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendPrivMsg_KeyDown);
            this.textBoxSendPrivMsg.ImeModeChanged += new System.EventHandler(this.textBoxSendPrivMsg_ImeModeChanged);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSendPrivMsg);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(843, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxInput;
        public System.Windows.Forms.TextBox textBoxSendPrivMsg;
    }
}
