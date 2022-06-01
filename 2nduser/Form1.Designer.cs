
namespace _2nduser
{
    partial class Form1
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.messagesTb = new System.Windows.Forms.TextBox();
            this.giberishTb = new System.Windows.Forms.TextBox();
            this.messagesLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(396, 103);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // messageTb
            // 
            this.messageTb.Location = new System.Drawing.Point(63, 394);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(312, 20);
            this.messageTb.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(396, 390);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // messagesTb
            // 
            this.messagesTb.Location = new System.Drawing.Point(484, 197);
            this.messagesTb.Multiline = true;
            this.messagesTb.Name = "messagesTb";
            this.messagesTb.Size = new System.Drawing.Size(160, 169);
            this.messagesTb.TabIndex = 3;
            // 
            // giberishTb
            // 
            this.giberishTb.Location = new System.Drawing.Point(63, 142);
            this.giberishTb.Name = "giberishTb";
            this.giberishTb.Size = new System.Drawing.Size(312, 20);
            this.giberishTb.TabIndex = 4;
            // 
            // messagesLb
            // 
            this.messagesLb.FormattingEnabled = true;
            this.messagesLb.Location = new System.Drawing.Point(63, 193);
            this.messagesLb.Name = "messagesLb";
            this.messagesLb.Size = new System.Drawing.Size(408, 173);
            this.messagesLb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messagesLb);
            this.Controls.Add(this.giberishTb);
            this.Controls.Add(this.messagesTb);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox messagesTb;
        private System.Windows.Forms.TextBox giberishTb;
        private System.Windows.Forms.ListBox messagesLb;
    }
}

