using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace BronwerCallSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string[] cmds = System.Environment.GetCommandLineArgs();
            foreach(string c in cmds)
            {
                textBox1.Text += c + "\r\n\r\n";

                string urlDec = System.Web.HttpUtility.UrlDecode(c + "\r\n\r\n");
                textBox2.Text += urlDec;
            }

            int byteCount = Encoding.GetEncoding("Shift_JIS").GetByteCount(textBox1.Text);

            datasizeLabel.Text = "文字数：" + textBox1.Text.Length.ToString() + "バイト数:" + byteCount.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
