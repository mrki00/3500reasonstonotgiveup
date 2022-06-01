
namespace _3500reasonstonotgiveup
{
    partial class Signature
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
            this.pathTb = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.browseDial = new System.Windows.Forms.OpenFileDialog();
            this.generatedTb = new System.Windows.Forms.TextBox();
            this.verifyTb = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.signatureL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(54, 59);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(337, 20);
            this.pathTb.TabIndex = 0;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(420, 56);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // browseDial
            // 
            this.browseDial.FileName = "openFileDialog1";
            // 
            // generatedTb
            // 
            this.generatedTb.Location = new System.Drawing.Point(54, 158);
            this.generatedTb.Name = "generatedTb";
            this.generatedTb.Size = new System.Drawing.Size(292, 20);
            this.generatedTb.TabIndex = 2;
            // 
            // verifyTb
            // 
            this.verifyTb.Location = new System.Drawing.Point(54, 259);
            this.verifyTb.Name = "verifyTb";
            this.verifyTb.Size = new System.Drawing.Size(292, 20);
            this.verifyTb.TabIndex = 3;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(374, 155);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(121, 23);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate signature";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(374, 255);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(121, 23);
            this.verifyBtn.TabIndex = 5;
            this.verifyBtn.Text = "Verify signature";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // signatureL
            // 
            this.signatureL.AutoSize = true;
            this.signatureL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signatureL.Location = new System.Drawing.Point(54, 323);
            this.signatureL.Name = "signatureL";
            this.signatureL.Size = new System.Drawing.Size(0, 25);
            this.signatureL.TabIndex = 6;
            // 
            // Signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.signatureL);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.verifyTb);
            this.Controls.Add(this.generatedTb);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathTb);
            this.Name = "Signature";
            this.Text = "Signature";
            this.Load += new System.EventHandler(this.Signature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.OpenFileDialog browseDial;
        private System.Windows.Forms.TextBox generatedTb;
        private System.Windows.Forms.TextBox verifyTb;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Label signatureL;
    }
}