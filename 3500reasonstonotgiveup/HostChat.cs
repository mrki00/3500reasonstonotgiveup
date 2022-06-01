using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;


namespace _3500reasonstonotgiveup
{
    public partial class HostChat : Form
    {
        public HostChat()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HostChat_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            MessageBox.Show(Form1.username);
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            messagesTb.Invoke((MethodInvoker)delegate ()
            {
                string[] tok = e.MessageString.Remove(e.MessageString.Length - 1, 1).Split('\\');
                messagesLb.Items.Insert(0,tok[0] + ":" + aes.AesDecryptString("b14ca5898a4e4133bbce2ea2315a1916", tok[1]));
                messagesTb.Text += aes.AesDecryptString("b14ca5898a4e4133bbce2ea2315a1916", e.MessageString.Remove(e.MessageString.Length -1, 1));
                //messagesTb.Text = e.MessageString.Remove(e.MessageString.Length -1, 1);
                //e.ReplyLine(e.MessageString);
            });
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            ipTb.Text = "127.0.0.1";
            portTb.Text = "1302";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipTb.Text);
            server.Start(ip, Convert.ToInt32(portTb.Text));
            statusL.Text = "Online";
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            
            server.Broadcast(Form1.username + ":\\" + aes.AesEncryptString("b14ca5898a4e4133bbce2ea2315a1916", messageTb.Text));
            messagesTb.Text += "\n" + messageTb;
            messagesLb.Items.Insert(0, Form1.username + ":" + messageTb.Text);
        }
    }
}
