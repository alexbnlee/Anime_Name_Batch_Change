using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anime_Name
{
    public partial class Preview01 : Form
    {
        public Preview01()
        {
            InitializeComponent();
        }

        private void Preview01_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.RichText01;   //获取Form1中的 public Static 变量！
        }
    }
}
