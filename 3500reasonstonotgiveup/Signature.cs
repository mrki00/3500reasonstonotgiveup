using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace _3500reasonstonotgiveup
{
    public partial class Signature : Form
    {
        public Signature()
        {
            InitializeComponent();
        }

        

        private void Signature_Load(object sender, EventArgs e)
        {
            
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Mrki\Desktop\";
            ofd.ShowDialog();
            pathTb.Text = ofd.FileName;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            byte[] data = File.ReadAllBytes(pathTb.Text);
            string tmp = Convert.ToBase64String(data);
            string hash = sha1.GetSha1(tmp);

            generatedTb.Text = hash;
            MessageBox.Show("done");
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (verifyTb.Text == generatedTb.Text)
            {
                signatureL.Text = "Signatures match";
                signatureL.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                signatureL.Text = "Signatures don't match";
                signatureL.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
