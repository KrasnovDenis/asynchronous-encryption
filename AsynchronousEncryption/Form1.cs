using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] cipherbytes;

        private void encrypt_Click(object sender, EventArgs e)
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] dataToEncrypt = byteConverter.GetBytes(input.Text);

            byte[] encryptedData = rsa.Encrypt(dataToEncrypt, false);

            string publicPrivateKeyXML = rsa.ToXmlString(true);
            private_key.Text = publicPrivateKeyXML;

            string publicOnlyKeyXML = rsa.ToXmlString(false);
            public_key.Text = publicOnlyKeyXML;

            cipherbytes = encryptedData;
            output.Text = byteConverter.GetString(cipherbytes);

        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            
            string publicPrivateKeyXML = private_key.Text;
            rsa.FromXmlString(publicPrivateKeyXML);

            byte[] plainbytes = rsa.Decrypt(
                        cipherbytes,
                        false); 

            output.Text = Encoding.UTF8.GetString(plainbytes);

        }

        private void save_key_Click(object sender, EventArgs e)
        {
            String key = private_key.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(filename, key);
            MessageBox.Show("Файл сохранен");
        }

        private void open_key_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);
            private_key.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
    }
}
