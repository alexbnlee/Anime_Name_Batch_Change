namespace Anime_Name
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btBrowseFolder01 = new System.Windows.Forms.Button();
            this.tbAnimeName01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browse01 = new System.Windows.Forms.Button();
            this.btOperate01 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFile01 = new System.Windows.Forms.CheckBox();
            this.btHelp01 = new System.Windows.Forms.Button();
            this.cbFolder01 = new System.Windows.Forms.CheckBox();
            this.cbPreview01 = new System.Windows.Forms.CheckBox();
            this.tbAnimePath01 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFile02 = new System.Windows.Forms.CheckBox();
            this.cbFolder02 = new System.Windows.Forms.CheckBox();
            this.btOperate02 = new System.Windows.Forms.Button();
            this.cbPreview02 = new System.Windows.Forms.CheckBox();
            this.btHelp02 = new System.Windows.Forms.Button();
            this.btBrowseFolder02 = new System.Windows.Forms.Button();
            this.tbAnimePath02 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browse02 = new System.Windows.Forms.Button();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAnimeName02 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "动漫名称：";
            // 
            // btBrowseFolder01
            // 
            this.btBrowseFolder01.Location = new System.Drawing.Point(23, 18);
            this.btBrowseFolder01.Name = "btBrowseFolder01";
            this.btBrowseFolder01.Size = new System.Drawing.Size(111, 31);
            this.btBrowseFolder01.TabIndex = 1;
            this.btBrowseFolder01.Text = "浏览文件夹";
            this.btBrowseFolder01.UseVisualStyleBackColor = true;
            this.btBrowseFolder01.Click += new System.EventHandler(this.btBrowseFolder01_Click);
            // 
            // tbAnimeName01
            // 
            this.tbAnimeName01.Location = new System.Drawing.Point(208, 39);
            this.tbAnimeName01.Name = "tbAnimeName01";
            this.tbAnimeName01.Size = new System.Drawing.Size(147, 29);
            this.tbAnimeName01.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "标志字段：";
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(21, 142);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(377, 29);
            this.tbIndex.TabIndex = 2;
            this.tbIndex.Text = "200";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.browse01);
            this.groupBox1.Controls.Add(this.tbIndex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAnimeName01);
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件名信息";
            // 
            // browse01
            // 
            this.browse01.Location = new System.Drawing.Point(208, 86);
            this.browse01.Name = "browse01";
            this.browse01.Size = new System.Drawing.Size(147, 31);
            this.browse01.TabIndex = 1;
            this.browse01.Text = "浏览文件...";
            this.browse01.UseVisualStyleBackColor = true;
            this.browse01.Click += new System.EventHandler(this.browse01_Click);
            // 
            // btOperate01
            // 
            this.btOperate01.Location = new System.Drawing.Point(196, 56);
            this.btOperate01.Name = "btOperate01";
            this.btOperate01.Size = new System.Drawing.Size(80, 38);
            this.btOperate01.TabIndex = 4;
            this.btOperate01.Text = "操作";
            this.btOperate01.UseVisualStyleBackColor = true;
            this.btOperate01.Click += new System.EventHandler(this.btOperate01_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 438);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btBrowseFolder01);
            this.tabPage1.Controls.Add(this.tbAnimePath01);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Case 1：等宽数字";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbFile01);
            this.groupBox3.Controls.Add(this.btHelp01);
            this.groupBox3.Controls.Add(this.btOperate01);
            this.groupBox3.Controls.Add(this.cbFolder01);
            this.groupBox3.Controls.Add(this.cbPreview01);
            this.groupBox3.Location = new System.Drawing.Point(23, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 133);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作及帮助";
            // 
            // cbFile01
            // 
            this.cbFile01.AutoSize = true;
            this.cbFile01.Location = new System.Drawing.Point(13, 33);
            this.cbFile01.Name = "cbFile01";
            this.cbFile01.Size = new System.Drawing.Size(93, 25);
            this.cbFile01.TabIndex = 6;
            this.cbFile01.Text = "操作文件";
            this.cbFile01.UseVisualStyleBackColor = true;
            this.cbFile01.CheckedChanged += new System.EventHandler(this.cbFile01_CheckedChanged);
            // 
            // btHelp01
            // 
            this.btHelp01.Location = new System.Drawing.Point(305, 56);
            this.btHelp01.Name = "btHelp01";
            this.btHelp01.Size = new System.Drawing.Size(100, 38);
            this.btHelp01.TabIndex = 4;
            this.btHelp01.Text = "显示帮助";
            this.btHelp01.UseVisualStyleBackColor = true;
            this.btHelp01.Click += new System.EventHandler(this.btHelp01_Click);
            // 
            // cbFolder01
            // 
            this.cbFolder01.AutoSize = true;
            this.cbFolder01.Location = new System.Drawing.Point(13, 96);
            this.cbFolder01.Name = "cbFolder01";
            this.cbFolder01.Size = new System.Drawing.Size(141, 25);
            this.cbFolder01.TabIndex = 6;
            this.cbFolder01.Text = "弹出操作文件夹";
            this.cbFolder01.UseVisualStyleBackColor = true;
            // 
            // cbPreview01
            // 
            this.cbPreview01.AutoSize = true;
            this.cbPreview01.Checked = true;
            this.cbPreview01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreview01.Location = new System.Drawing.Point(13, 64);
            this.cbPreview01.Name = "cbPreview01";
            this.cbPreview01.Size = new System.Drawing.Size(125, 25);
            this.cbPreview01.TabIndex = 6;
            this.cbPreview01.Text = "显示操作预览";
            this.cbPreview01.UseVisualStyleBackColor = true;
            // 
            // tbAnimePath01
            // 
            this.tbAnimePath01.Location = new System.Drawing.Point(150, 20);
            this.tbAnimePath01.Name = "tbAnimePath01";
            this.tbAnimePath01.Size = new System.Drawing.Size(290, 29);
            this.tbAnimePath01.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btBrowseFolder02);
            this.tabPage2.Controls.Add(this.tbAnimePath02);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Case 2：非等宽数字";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbFile02);
            this.groupBox4.Controls.Add(this.cbFolder02);
            this.groupBox4.Controls.Add(this.btOperate02);
            this.groupBox4.Controls.Add(this.cbPreview02);
            this.groupBox4.Controls.Add(this.btHelp02);
            this.groupBox4.Location = new System.Drawing.Point(23, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 123);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "操作及帮助";
            // 
            // cbFile02
            // 
            this.cbFile02.AutoSize = true;
            this.cbFile02.Location = new System.Drawing.Point(13, 30);
            this.cbFile02.Name = "cbFile02";
            this.cbFile02.Size = new System.Drawing.Size(93, 25);
            this.cbFile02.TabIndex = 13;
            this.cbFile02.Text = "操作文件";
            this.cbFile02.UseVisualStyleBackColor = true;
            this.cbFile02.CheckedChanged += new System.EventHandler(this.cbFile02_CheckedChanged);
            // 
            // cbFolder02
            // 
            this.cbFolder02.AutoSize = true;
            this.cbFolder02.Location = new System.Drawing.Point(13, 88);
            this.cbFolder02.Name = "cbFolder02";
            this.cbFolder02.Size = new System.Drawing.Size(141, 25);
            this.cbFolder02.TabIndex = 13;
            this.cbFolder02.Text = "弹出操作文件夹";
            this.cbFolder02.UseVisualStyleBackColor = true;
            // 
            // btOperate02
            // 
            this.btOperate02.Location = new System.Drawing.Point(191, 51);
            this.btOperate02.Name = "btOperate02";
            this.btOperate02.Size = new System.Drawing.Size(80, 38);
            this.btOperate02.TabIndex = 10;
            this.btOperate02.Text = "操作";
            this.btOperate02.UseVisualStyleBackColor = true;
            this.btOperate02.Click += new System.EventHandler(this.btOperate02_Click);
            // 
            // cbPreview02
            // 
            this.cbPreview02.AutoSize = true;
            this.cbPreview02.Checked = true;
            this.cbPreview02.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreview02.Location = new System.Drawing.Point(13, 59);
            this.cbPreview02.Name = "cbPreview02";
            this.cbPreview02.Size = new System.Drawing.Size(125, 25);
            this.cbPreview02.TabIndex = 13;
            this.cbPreview02.Text = "显示操作预览";
            this.cbPreview02.UseVisualStyleBackColor = true;
            // 
            // btHelp02
            // 
            this.btHelp02.Location = new System.Drawing.Point(304, 51);
            this.btHelp02.Name = "btHelp02";
            this.btHelp02.Size = new System.Drawing.Size(100, 38);
            this.btHelp02.TabIndex = 11;
            this.btHelp02.Text = "显示帮助";
            this.btHelp02.UseVisualStyleBackColor = true;
            this.btHelp02.Click += new System.EventHandler(this.btHelp02_Click);
            // 
            // btBrowseFolder02
            // 
            this.btBrowseFolder02.Location = new System.Drawing.Point(22, 21);
            this.btBrowseFolder02.Name = "btBrowseFolder02";
            this.btBrowseFolder02.Size = new System.Drawing.Size(111, 31);
            this.btBrowseFolder02.TabIndex = 7;
            this.btBrowseFolder02.Text = "浏览文件夹";
            this.btBrowseFolder02.UseVisualStyleBackColor = true;
            this.btBrowseFolder02.Click += new System.EventHandler(this.btBrowseFolder02_Click);
            // 
            // tbAnimePath02
            // 
            this.tbAnimePath02.Location = new System.Drawing.Point(149, 23);
            this.tbAnimePath02.Name = "tbAnimePath02";
            this.tbAnimePath02.Size = new System.Drawing.Size(291, 29);
            this.tbAnimePath02.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.browse02);
            this.groupBox2.Controls.Add(this.tbEnd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbStart);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbAnimeName02);
            this.groupBox2.Location = new System.Drawing.Point(23, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 208);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名信息";
            // 
            // browse02
            // 
            this.browse02.Location = new System.Drawing.Point(204, 72);
            this.browse02.Name = "browse02";
            this.browse02.Size = new System.Drawing.Size(147, 31);
            this.browse02.TabIndex = 5;
            this.browse02.Text = "浏览文件...";
            this.browse02.UseVisualStyleBackColor = true;
            this.browse02.Click += new System.EventHandler(this.browse02_Click);
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(65, 163);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(332, 29);
            this.tbEnd.TabIndex = 4;
            this.tbEnd.Text = "English";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "动漫名称：";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(65, 118);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(332, 29);
            this.tbStart.TabIndex = 2;
            this.tbStart.Text = "Episode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "后：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "前：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "标志字段：";
            // 
            // tbAnimeName02
            // 
            this.tbAnimeName02.Location = new System.Drawing.Point(204, 35);
            this.tbAnimeName02.Name = "tbAnimeName02";
            this.tbAnimeName02.Size = new System.Drawing.Size(147, 29);
            this.tbAnimeName02.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 438);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Anime Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBrowseFolder01;
        private System.Windows.Forms.TextBox tbAnimeName01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOperate01;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbAnimePath01;
        private System.Windows.Forms.Button btHelp01;
        private System.Windows.Forms.Button btBrowseFolder02;
        private System.Windows.Forms.TextBox tbAnimePath02;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAnimeName02;
        private System.Windows.Forms.Button btHelp02;
        private System.Windows.Forms.Button btOperate02;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.CheckBox cbFile01;
        private System.Windows.Forms.CheckBox cbFile02;
        private System.Windows.Forms.Button browse01;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button browse02;
        private System.Windows.Forms.CheckBox cbPreview01;
        private System.Windows.Forms.CheckBox cbPreview02;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbFolder01;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbFolder02;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

