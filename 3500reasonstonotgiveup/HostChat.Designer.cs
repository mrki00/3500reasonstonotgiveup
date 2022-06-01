
namespace _3500reasonstonotgiveup
{
    partial class HostChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusL = new System.Windows.Forms.Label();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.portTb = new System.Windows.Forms.TextBox();
            this.ipTb = new System.Windows.Forms.TextBox();
            this.messagesTb = new System.Windows.Forms.TextBox();
            this.messagesLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // statusL
            // 
            this.statusL.AutoSize = true;
            this.statusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusL.Location = new System.Drawing.Point(183, 31);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(83, 29);
            this.statusL.TabIndex = 1;
            this.statusL.Text = "Offline";
            // 
            // messageTb
            // 
            this.messageTb.Location = new System.Drawing.Point(70, 383);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(464, 20);
            this.messageTb.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(606, 383);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(360, 112);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(459, 112);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // portTb
            // 
            this.portTb.Location = new System.Drawing.Point(256, 114);
            this.portTb.Name = "portTb";
            this.portTb.Size = new System.Drawing.Size(76, 20);
            this.portTb.TabIndex = 7;
            this.portTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ipTb
            // 
            this.ipTb.Location = new System.Drawing.Point(70, 114);
            this.ipTb.Name = "ipTb";
            this.ipTb.Size = new System.Drawing.Size(165, 20);
            this.ipTb.TabIndex = 8;
            // 
            // messagesTb
            // 
            this.messagesTb.Location = new System.Drawing.Point(549, 161);
            this.messagesTb.Multiline = true;
            this.messagesTb.Name = "messagesTb";
            this.messagesTb.Size = new System.Drawing.Size(132, 173);
            this.messagesTb.TabIndex = 9;
            this.messagesTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // messagesLb
            // 
            this.messagesLb.FormattingEnabled = true;
            this.messagesLb.Location = new System.Drawing.Point(70, 161);
            this.messagesLb.Name = "messagesLb";
            this.messagesLb.Size = new System.Drawing.Size(402, 173);
            this.messagesLb.TabIndex = 10;
            // 
            // HostChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messagesLb);
            this.Controls.Add(this.messagesTb);
            this.Controls.Add(this.ipTb);
            this.Controls.Add(this.portTb);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.statusL);
            this.Controls.Add(this.label1);
            this.Name = "HostChat";
            this.Text = "HostChat";
            this.Load += new System.EventHandler(this.HostChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusL;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox portTb;
        private System.Windows.Forms.TextBox ipTb;
        private System.Windows.Forms.TextBox messagesTb;
        private System.Windows.Forms.ListBox messagesLb;
    }
}