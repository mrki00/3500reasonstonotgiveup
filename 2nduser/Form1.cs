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

namespace _2nduser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Enabled = false;
            client.Connect("127.0.0.1", Convert.ToInt32("1302"));
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to txtStatus
            messagesTb.Invoke((MethodInvoker)delegate ()
            {
                giberishTb.Text = e.MessageString;//.Remove(e.MessageString.Length - 1, 1);
                //messagesTb.Text += e.MessageString;
                messagesLb.Items.Insert(0, aes.AesDecryptString("b14ca5898a4e4133bbce2ea2315a1916", e.MessageString));
            });
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var tmp = messageTb.Text;
            messagesLb.Items.Insert(0, tmp);
            client.WriteLine(aes.AesEncryptString("b14ca5898a4e4133bbce2ea2315a1916", tmp));
            //MessageBox.Show(aes.AesEncryptString("b14ca5898a4e4133bbce2ea2315a1916", tmp));
        }
    }
}
