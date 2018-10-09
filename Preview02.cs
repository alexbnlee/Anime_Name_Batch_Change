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
    public partial class Preview02 : Form
    {
        public Preview02()
        {
            InitializeComponent();
        }

        private void Preview02_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.RichText02;   //获取Form1中的 public Static 变量！
        }
    }
}
