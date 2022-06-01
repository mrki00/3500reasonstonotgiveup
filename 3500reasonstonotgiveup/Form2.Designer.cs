
namespace _3500reasonstonotgiveup
{
    partial class Form2
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
            this.chatServer = new System.Windows.Forms.Button();
            this.chatClient = new System.Windows.Forms.Button();
            this.fileServer = new System.Windows.Forms.Button();
            this.fileClient = new System.Windows.Forms.Button();
            this.signatureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatServer
            // 
            this.chatServer.Location = new System.Drawing.Point(86, 42);
            this.chatServer.Name = "chatServer";
            this.chatServer.Size = new System.Drawing.Size(75, 23);
            this.chatServer.TabIndex = 0;
            this.chatServer.Text = "Host Chat";
            this.chatServer.UseVisualStyleBackColor = true;
            this.chatServer.Click += new System.EventHandler(this.chatServer_Click);
            // 
            // chatClient
            // 
            this.chatClient.Location = new System.Drawing.Point(190, 42);
            this.chatClient.Name = "chatClient";
            this.chatClient.Size = new System.Drawing.Size(75, 23);
            this.chatClient.TabIndex = 1;
            this.chatClient.Text = "Join Chat";
            this.chatClient.UseVisualStyleBackColor = true;
            this.chatClient.Click += new System.EventHandler(this.chatClient_Click);
            // 
            // fileServer
            // 
            this.fileServer.Location = new System.Drawing.Point(86, 107);
            this.fileServer.Name = "fileServer";
            this.fileServer.Size = new System.Drawing.Size(75, 23);
            this.fileServer.TabIndex = 2;
            this.fileServer.Text = "Recieve file";
            this.fileServer.UseVisualStyleBackColor = true;
            this.fileServer.Click += new System.EventHandler(this.fileServer_Click);
            // 
            // fileClient
            // 
            this.fileClient.Location = new System.Drawing.Point(190, 107);
            this.fileClient.Name = "fileClient";
            this.fileClient.Size = new System.Drawing.Size(75, 23);
            this.fileClient.TabIndex = 3;
            this.fileClient.Text = "Send File";
            this.fileClient.UseVisualStyleBackColor = true;
            this.fileClient.Click += new System.EventHandler(this.fileClient_Click);
            // 
            // signatureBtn
            // 
            this.signatureBtn.Location = new System.Drawing.Point(138, 153);
            this.signatureBtn.Name = "signatureBtn";
            this.signatureBtn.Size = new System.Drawing.Size(75, 23);
            this.signatureBtn.TabIndex = 4;
            this.signatureBtn.Text = "Signature";
            this.signatureBtn.UseVisualStyleBackColor = true;
            this.signatureBtn.Click += new System.EventHandler(this.signatureBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 208);
            this.Controls.Add(this.signatureBtn);
            this.Controls.Add(this.fileClient);
            this.Controls.Add(this.fileServer);
            this.Controls.Add(this.chatClient);
            this.Controls.Add(this.chatServer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chatServer;
        private System.Windows.Forms.Button chatClient;
        private System.Windows.Forms.Button fileServer;
        private System.Windows.Forms.Button fileClient;
        private System.Windows.Forms.Button signatureBtn;
    }
}