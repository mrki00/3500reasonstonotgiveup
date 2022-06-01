using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3500reasonstonotgiveup
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chatServer_Click(object sender, EventArgs e)
        {
            var HostChat = new HostChat();
            HostChat.Show();
            this.Hide();
        }

        private void chatClient_Click(object sender, EventArgs e)
        {
            var JoinChat = new JoinChat();
            JoinChat.Show();
            this.Hide();
        }

        private void signatureBtn_Click(object sender, EventArgs e)
        {
            var Signature = new Signature();
            Signature.Show();
            this.Hide();
        }

        private void fileServer_Click(object sender, EventArgs e)
        {
            var RecieveFile = new ReciveFile();
            RecieveFile.Show();
            this.Hide();
        }

        private void fileClient_Click(object sender, EventArgs e)
        {
            var SendFile = new SendFile();
            SendFile.Show();
            this.Hide();
        }
    }
}
