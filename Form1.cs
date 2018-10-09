using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Anime_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 全局变量
        Helper01 FrmHelp01;     //实例化Helper01
        Helper02 FrmHelp02;     //实例化Helper02

        Preview01 pre01;    //实例化Preview01
        Preview02 pre02;    //实例化Preview02

        public static string RichText01;    //传递给Preview01的弹出预览框内容
        public static string RichText02;    //传递给Preview02的弹出预览框内容

        bool IsHelperClosed01 = true;   //判断Helper01是否关闭
        bool IsHelperClosed02 = true;   //判断Helper02是否关闭
        #endregion

        #region Form1事件
        private void Form1_Load(object sender, EventArgs e)
        {
            tbAnimePath01.Text = Directory.GetCurrentDirectory();   //获取程序所在的文件夹地址
            int index = tbAnimePath01.Text.LastIndexOf("\\");
            string name = tbAnimePath01.Text.Substring(index + 1);
            tbAnimeName01.Text = name;  //获取所在文件夹的名称，此名称即为anime的名称

            tbAnimePath02.Text = Directory.GetCurrentDirectory();
            tbAnimeName02.Text = name;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (!IsHelperClosed01)  //如果Helper01没有关闭！
            {
                FrmHelp01.Left = Left + Width + 10;
                FrmHelp01.Top = Top + Height / 2 - FrmHelp01.Height / 2;
            }

            if (!IsHelperClosed02)  //如果Helper02没有关闭！
            {
                FrmHelp02.Left = Left + Width + 10;
                FrmHelp02.Top = Top + Height / 2 - FrmHelp02.Height / 2;
            }
        }
        #endregion
    
        #region 简单按钮事件
        private void btBrowseFolder01_Click(object sender, EventArgs e) //浏览文件夹01
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Directory.GetCurrentDirectory();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbAnimePath01.Text = fbd.SelectedPath;
                int index = tbAnimePath01.Text.LastIndexOf("\\");
                string name = tbAnimePath01.Text.Substring(index + 1);
                tbAnimeName01.Text = name;
            }
        }

        private void btBrowseFolder02_Click(object sender, EventArgs e) //浏览文件夹02
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Directory.GetCurrentDirectory();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbAnimePath02.Text = fbd.SelectedPath;
                int index = tbAnimePath02.Text.LastIndexOf("\\");
                string name = tbAnimePath02.Text.Substring(index + 1);
                tbAnimeName02.Text = name;
            }
        }

        private void browse01_Click(object sender, EventArgs e)   //浏览文件01
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = tbAnimePath01.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbIndex.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private void browse02_Click(object sender, EventArgs e)   //浏览文件02
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = tbAnimePath02.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbStart.Text = Path.GetFileName(ofd.FileName);
                tbEnd.Text = Path.GetFileName(ofd.FileName);
            }
        }
        #endregion

        private void btOperate01_Click(object sender, EventArgs e)  //操作01
        {
            #region 文本框检测
            if (!Directory.Exists(tbAnimePath01.Text))
            {
                MessageBox.Show("请选择正确的文件夹！");
                return;
            }

            if (tbAnimeName01.Text == "")
            {
                MessageBox.Show("请输入动漫名称！");
                return;
            }

            if (tbIndex.Text == "")
            {
                MessageBox.Show("请输入标志字段！");
                return;
            }
            #endregion

            string animeName = tbAnimeName01.Text.Trim();   //获取动漫的名字
            string findStr = tbIndex.Text.Trim();     //标志性文字，共有的文字
            string newName;                     //新名称
            int indexStr;                       //找到地址中最后一个“\”的索引，提取出名称
            string fileRename;                  //重新定义的文件路径
            Hashtable multi = new Hashtable();  //用来记录同名的次数
            StringBuilder newFileNames = new StringBuilder();   //记录所有文件名称
            int fileWidth = 200;    //用来限制预览框的宽度

            foreach (string file in Directory.GetFiles(tbAnimePath01.Text))
            {
                indexStr = file.IndexOf(findStr);
                if (indexStr == -1)             //如果不存在标志文字，跳出次循环，继续下一个
                    continue;

                newName = animeName + " - 0" + file.Substring(indexStr + findStr.Length, 2) + Path.GetExtension(file);
                fileRename = tbAnimePath01.Text + @"\" + newName;

                #region 是否操作文件
                if (cbFile01.Checked == true)
                {
                    if (File.Exists(fileRename))    //存在同名文件
                    {
                        MessageBox.Show("此文件存在！");
                        multi[newName] = Convert.ToInt32(multi[newName]) + 1;   //将同名文件名的value值加1
                        newName = animeName + " - 0" + file.Substring(indexStr + 3, 2) + "(" + multi[newName] + ").flv";
                        fileRename = tbAnimePath01.Text + @"\" + newName;
                    }
                    else
                    {
                        multi.Add(newName, 1);      //不存在同名文件则增加到hashtable中
                    }

                	File.Move(file, fileRename);
                }
                #endregion

                fileWidth = newName.Length * 15;
                newFileNames.AppendLine(newName);
            }

            #region 是否显示预览框
            if (cbPreview01.Checked)
            {
	            RichText01 = newFileNames.ToString();   //赋值操作后的文件名称
	
	            if (RichText01.Trim() != "")    //若内容存在
	            {
		            pre01 = new Preview01();
		            pre01.Show();
                    timer1.Enabled = true;
		            pre01.Width = fileWidth;
		            pre01.Left = Left + Width + 10;
		            pre01.Top = Top + Height / 2 - pre01.Height / 2;
	            } 
	            else
	            {
	                MessageBox.Show("没有任何可操作的文件!\n确保您的输入无错！\n特别注意空格！","警告",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
            }
            #endregion

            #region 是否打开文件夹
            if (cbFile01.Checked == true && cbPreview01.Checked == true)
            {
                System.Diagnostics.Process.Start("Explorer.exe", tbAnimePath01.Text);
            }
            #endregion
        }

        private void btOperate02_Click(object sender, EventArgs e)  //操作02
        {
            #region 文本框检测
            if (!Directory.Exists(tbAnimePath02.Text))
            {
                MessageBox.Show("请选择正确的文件夹！");
                return;
            }

            if (tbAnimeName02.Text == "")
            {
                MessageBox.Show("请输入动漫名称！");
                return;
            }

            if (tbStart.Text == "")
            {
                MessageBox.Show("请输入标志字段！");
                return;
            }

            if (tbEnd.Text == "")
            {
                MessageBox.Show("请输入标志字段！");
                return;
            }
            #endregion

            string animeName2 = tbAnimeName02.Text;      //获取动漫的名字
            string findFront2 = tbStart.Text.Trim();     //标志性文字，共有的文字
            string findAfter2 = tbEnd.Text.Trim();
            int num2;
            string newName2;                            //新名称
            int indexFront2;
            int indexAfter2;
            string fileRename2;                     //重新定义的文件路径
            Hashtable multi2 = new Hashtable();     //用来记录同名的次数
            StringBuilder newFileNames2 = new StringBuilder();   //记录所有文件名称
            int fileWidth2 = 200;       //用来限制预览框的宽度

            foreach (string file in Directory.GetFiles(tbAnimePath02.Text))
            {
                indexFront2 = file.IndexOf(findFront2);     //前者标志 的索引
                indexAfter2 = file.IndexOf(findAfter2);     //后者标志 的索引

                if (indexFront2 == -1 || indexAfter2 == -1)             //如果不存在标志文字，跳出次循环，继续下一个
                    continue;

                int numStart = indexFront2 + findFront2.Length;
                int numLength = indexAfter2 - numStart;
                string numSpace = file.Substring(numStart, numLength);
                num2 = Convert.ToInt32(numSpace.Trim());

                newName2 = animeName2 + " - " + String.Format("{0:000}", num2) + Path.GetExtension(file);
                fileRename2 = tbAnimePath02.Text + @"\" + newName2;

                #region 是否操作文件
                if (cbFile02.Checked == true)
                {
                    if (File.Exists(fileRename2))    //存在同名文件
                    {
                        MessageBox.Show("此文件存在！");
                        multi2[newName2] = Convert.ToInt32(multi2[newName2]) + 1;   //将同名文件名的value值加1
                        newName2 = animeName2 + num2 + "(" + multi2[newName2] + ")" + Path.GetExtension(file);
                        fileRename2 = tbAnimePath01.Text + @"\" + newName2;
                    }
                    else
                    {
                        multi2.Add(newName2, 1);      //不存在同名文件则增加到hashtable中
                    }

                    File.Move(file, fileRename2);
                }
                #endregion
                fileWidth2 = newName2.Length * 15;
                newFileNames2.AppendLine(newName2);
            }

            #region 是否显示预览框
            if (cbPreview02.Checked)
            {
	            RichText02 = newFileNames2.ToString();
	
	            if (RichText02.Trim() != "")
	            {
	                pre02 = new Preview02();
	                pre02.Show();
                    timer2.Enabled = true;
	                pre02.Width = fileWidth2;
	                pre02.Left = Left + Width + 10;
	                pre02.Top = Top + Height / 2 - pre02.Height / 2;
	            }
	            else
	            {
                    MessageBox.Show("没有任何可操作的文件!\n确保您的输入无错！\n特别注意空格！", "警告",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
            }
            #endregion

            #region 是否打开文件夹
            if (cbFile02.Checked == true && cbPreview02.Checked == true)
            {
                System.Diagnostics.Process.Start("Explorer.exe", tbAnimePath02.Text);
            }
            #endregion
        }

        private void btHelp01_Click(object sender, EventArgs e)   //帮助01
        {
            if (!IsHelperClosed01)    //如果Helper01没有关闭，则关闭Helper01，并将text改为“显示帮助”！
            {
                FrmHelp01.Close();
                btHelp01.Text = "显示帮助";
            }
            else                    //如果Helper01已经关闭，则显示Helper01，并将text改为“关闭帮助”
            {
                FrmHelp01 = new Helper01();     //实例化一个Helper01
                
                FrmHelp01.Load += new EventHandler(HelperLoad01);   //定义Helper01加载事件！
                //定义Helper01的关闭事件，当关闭窗体的时候，将text改为“显示帮助”
                FrmHelp01.FormClosed += new System.Windows.Forms.FormClosedEventHandler(HelperClosed01);
                FrmHelp01.Show();
                FrmHelp01.Left = Left + Width + 10;     //Helper01显示在主窗体右边一点
                FrmHelp01.Top = Top + Height / 2 - FrmHelp01.Height / 2;    //Helper01与主窗体居中
                btHelp01.Text = "关闭帮助";
            }
        }

        private void btHelp02_Click(object sender, EventArgs e)   //帮助02
        {
            if (!IsHelperClosed02)
            {
                FrmHelp02.Close();
                btHelp02.Text = "显示帮助";
            }
            else
            {
                FrmHelp02 = new Helper02();
                FrmHelp02.Load += new System.EventHandler(HelperLoad02);
                FrmHelp02.FormClosed += new System.Windows.Forms.FormClosedEventHandler(HelperClosed02);
                FrmHelp02.Show();
                FrmHelp02.Left = Left + Width + 10;
                FrmHelp02.Top = Top + Height / 2 - FrmHelp02.Height / 2;
                btHelp02.Text = "关闭帮助";
            }
        }

        #region 帮助相关方法
        private void HelperLoad01(object sender, EventArgs e)
        {
            IsHelperClosed01 = false;   //窗体加载的时候，赋值为false
        }

        private void HelperClosed01(object sender, FormClosedEventArgs e)
        {
            IsHelperClosed01 = true;    //窗体关闭的时候，赋值为true
            btHelp01.Text = "显示帮助";
        }

        private void HelperLoad02(object sender, EventArgs e)
        {
            IsHelperClosed02 = false;
        }

        private void HelperClosed02(object sender, FormClosedEventArgs e)
        {
            IsHelperClosed02 = true;
            btHelp02.Text = "显示帮助";
        }
        #endregion

        #region 复选框及预览的简单操作事件
        private void cbFile01_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFile01.Checked)
            {
                cbPreview01.Checked = false;
            }
            else
            {
                cbPreview01.Checked = true;
            }
        }

        private void cbFile02_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFile02.Checked)
            {
                cbPreview02.Checked = false;
            }
            else
            {
                cbPreview02.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pre01.Close();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pre02.Close();
            timer2.Enabled = false;
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 1 && IsHelperClosed01 == false)
            //{
            //    FrmHelp01.Close();
            //}
            //else if (tabControl1.SelectedIndex == 0 && IsHelperClosed02 == false)
            //{
            //    FrmHelp02.Close();
            //}
        }
    }
}


//             ╔╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╗
//             ╠╬╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╬╣
//             ╠╣ Bleach - 004.flv  ╠╣
//             ╠╣ Bleach - 005.flv  ╠╣
//             ╠╣ Bleach - 006.flv  ╠╣
//             ╠╣ Bleach - 007.flv  ╠╣
//             ╠╣ Bleach - 009.flv  ╠╣
//             ╠╣ Bleach - 010.flv  ╠╣
//             ╠╣ Bleach - 011.flv  ╠╣
//             ╠╣ Bleach - 013.flv  ╠╣
//             ╠╣ Bleach - 014.flv  ╠╣
//             ╠╣ Bleach - 014.flv  ╠╣
//             ╠╣ Bleach - 012.flv  ╠╣
//             ╠╣ Bleach - 015.flv  ╠╣
//             ╠╬╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╬╣
//             ╚╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╝



