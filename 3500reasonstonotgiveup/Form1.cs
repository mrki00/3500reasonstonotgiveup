using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _3500reasonstonotgiveup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
        string encrypt (string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            string hash = BitConverter.ToString(bytes).Replace("-", String.Empty);
            return hash;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is closed system, registration in not available!");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            username = usernameTb.Text;
            string hash = encrypt(usernameTb.Text + passwordTb.Text);
            MessageBox.Show(hash);
            var form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
