using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint ipServer;
        int sec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string dt = DateTime.Now.ToString();
        public string Encrypted(string rawString, string keyText, string iv)
        {
            string rawText = rawString;
            string key = keyText;
            string encryptedText = aes.Encrypt(rawText, key, dt);
            return encryptedText;
        }
        public string Decrypted(string textEncrypted, string time)
        {
            string encryptedText = textEncrypted;
            string key = txtKey.Text;
            string decryptedText = aes.Decrypt(textEncrypted, key, time);
            return decryptedText;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(ipServer);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtEncrypted.Text;
            byte[] data = new byte[1024*24];
            data = Encoding.ASCII.GetBytes(text);
            listBox1.Items.Add("You : " + txtMessage.Text);
            txtMessage.Text = "";
            KhoiTaoTimer();
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            string s = Encoding.ASCII.GetString(data);
            string[] arraystring = s.Split(';');
            string encryptedText = arraystring[0];
            string dt = arraystring[1];
            string md5EncryptedText = arraystring[2];
            txtKey.Text = arraystring[3];
            string paddingValue = arraystring[4];
            string hashEncryptedText = MD5.HashMd5(encryptedText);
            if (md5EncryptedText == hashEncryptedText)
            {
                txtMessaged_Receive.Text = encryptedText;
                string rawText = Decrypted(txtMessaged_Receive.Text, dt);
                txtDecrypted.Text = rawText.Substring(0, rawText.Length - int.Parse(paddingValue));
                listBox1.Items.Add("Him :" + txtDecrypted.Text);
            }
            else
            {
                listBox1.Invoke((MethodInvoker)delegate()
                {
                    listBox1.Items.Add("Error: Noi dung da bi thay doi.");
                });
            }
            IPEndPoint ip = (IPEndPoint)client.RemoteEndPoint;
            txtIP.Text = ip.Address.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            dt = MD5.HashMd5(DateTime.Now.ToString());
            string valuePadding = paddingData().ToString();
            string encryptedText = Encrypted(txtPadding.Text, txtKey.Text, dt);
            string MD5encryptedText = MD5.HashMd5(encryptedText);
            txtEncrypted.Text = encryptedText + ";" + dt + ";" + MD5encryptedText + ";"+ txtKey.Text + ";" + valuePadding;
        }

        public static string RandomString(int size)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 122)));
                sb.Append(c);
            }
            return sb.ToString();
        }
        private int paddingData()
        {
            string Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUniversalTime().ToString("yyyyMMddHHmmss");
            string MHtimeStamp = MD5.HashMd5(Timestamp);
            int soByteCuaChuoi = UTF8Encoding.UTF8.GetByteCount(txtMessage.Text);
            int lengthNeed = 32 - soByteCuaChuoi;
            int i = 0;
            string tmpTime = string.Empty;
            if (soByteCuaChuoi % 16 != 0)
            {
                i = 1;
                int length = soByteCuaChuoi;
                while (length % 16 != 0)
                {
                    tmpTime = MHtimeStamp.Substring(0, i);
                    length = length + 1;
                    i++;
                }
            }
            txtPadding.Text = txtMessage.Text + tmpTime;
            return i - 1;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtKey.Text = RandomString(16);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             sec = sec + 1;
             if (sec == 20)
             {
                 MessageBox.Show("Time Out. Please change another key !!!", "CLIENT-01");
                 timer1.Stop();
                 sec = 0;
                 txtKey.Clear();
                 txtEncrypted.Clear();
                 txtDecrypted.Clear();
                 btnEncrypt.Enabled = true;
                 btnSend.Enabled = true;
             }  
        }
        public void KhoiTaoTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnGetIp_Click(object sender, EventArgs e)
        {
            txtIP.Text = "127.0.0.1";
        }
        
    }
}