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
using SimpleTCP;
using System.Security.Cryptography;

namespace _3500reasonstonotgiveup
{
    public partial class SendFile : Form
    {
        public SendFile()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void SendFile_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Mrki\Desktop\";
            ofd.ShowDialog();
            pathTb.Text = ofd.FileName;

            
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            byte[] data = File.ReadAllBytes(pathTb.Text);


            string tmp = Convert.ToBase64String(data);


            var csp = new RSACryptoServiceProvider(2048);

            string filename = pathTb.Text.Replace("C:\\Users\\Mrki\\Desktop\\", "");

            Aes aee = Aes.Create();
            aee.GenerateIV();
            aee.GenerateKey();
            var plainTextData = Convert.ToBase64String(aee.Key);
            //MessageBox.Show(Convert.ToBase64String(aee.Key));
            //b14ca5898a4e4133bbce2ea2315a1916 valid aes key
            tmp = aes.AesEncryptString(Convert.ToBase64String(aee.Key).Substring(0, 32), tmp);
          
            var privKeyString = File.ReadAllText("privkey.xml");
            var sr = new System.IO.StringReader(privKeyString);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            var privKey = (RSAParameters)xs.Deserialize(sr);
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privKey);
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData); 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);
            var cypherText = Convert.ToBase64String(bytesCypherText);

            tmp = filename + "\\" + privKeyString + "\\" + cypherText + "\\" + tmp;

            client.WriteLine(tmp);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Enabled = false;
            client.Connect("127.0.0.1", Convert.ToInt32("1305"));
        }

    }
}
