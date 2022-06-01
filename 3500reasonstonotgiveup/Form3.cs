using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Linq;

namespace _3500reasonstonotgiveup
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show(RecordToXmlNode(1, "2018-08-10", "mat", "ime", 4));
        }
        private string RecordToXmlNode(int id, string datum, string pred, string ime, int ocj)
        {
            XElement zapis =
            new XElement("zapis",
                new XElement("ID", id),
                new XElement("Datum", datum),
                new XElement("Kolegij", pred),
                new XElement("Student", ime),
                new XElement("Ocjena", ocj)
                );
            return zapis.ToString();

        }

    }
}
