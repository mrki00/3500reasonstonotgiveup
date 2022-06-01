using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using SimpleTCP;
using System.Security.Cryptography;

namespace _3500reasonstonotgiveup
{
    public partial class ReciveFile : Form
    {
        public ReciveFile()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void ReciveFile_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            tb.Invoke((MethodInvoker)delegate ()
            {
                var tmp = e.MessageString.Remove(e.MessageString.Length - 1, 1);
                string[] tok = tmp.Split('\\');

                /*
                var sr = new System.IO.StringReader(tok[1]);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                var pubKey = (RSAParameters)xs.Deserialize(sr);
                string pubKeyString;
                {
                    var sw = new System.IO.StringWriter();
                    xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                    xs.Serialize(sw, pubKey);
                    pubKeyString = sw.ToString();
                }
                var bytesCypherText = Convert.FromBase64String(tok[2]);
                var test1 = csp.ExportParameters(true);
                var test2 = csp.ExportParameters(false);
                */
                var csp = new RSACryptoServiceProvider(2048);
                var pubKeyString = File.ReadAllText("privkey.xml");
                var sr = new System.IO.StringReader(pubKeyString);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                var pubKey = (RSAParameters)xs.Deserialize(sr);

                //csp.FromXmlString(tok[1]);
                csp.ImportParameters(pubKey);
                csp.PersistKeyInCsp = true;
                var bytesPlainTextData = csp.Decrypt(Convert.FromBase64String(tok[2]), false);
                var plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);

                

                byte[] data = Convert.FromBase64String(aes.AesDecryptString(plainTextData.Substring(0, 32), tok[3]));
                File.WriteAllBytes(tok[0], data);
                MessageBox.Show("done");
                
            });
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
            server.Start(ip, Convert.ToInt32("1305"));
        }
    }
}
