namespace 搜索
{
    partial class 检索
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.加载 = new System.Windows.Forms.Button();
            this.结果 = new System.Windows.Forms.TextBox();
            this.作者 = new System.Windows.Forms.Label();
            this.搜索 = new System.Windows.Forms.Label();
            this.书名 = new System.Windows.Forms.Label();
            this.作者框 = new System.Windows.Forms.TextBox();
            this.搜索按钮 = new System.Windows.Forms.Button();
            this.书名框 = new System.Windows.Forms.TextBox();
            this.生成 = new System.ComponentModel.BackgroundWorker();
            this.文件 = new System.Windows.Forms.OpenFileDialog();
            this.检索书名 = new System.ComponentModel.BackgroundWorker();
            this.检索作者 = new System.ComponentModel.BackgroundWorker();
            this.输出 = new System.ComponentModel.BackgroundWorker();
            this.取消 = new System.Windows.Forms.Button();
            this.进度条 = new System.Windows.Forms.ProgressBar();
            this.索引框 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // 加载
            // 
            this.加载.Location = new System.Drawing.Point(732, 47);
            this.加载.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.加载.Name = "加载";
            this.加载.Size = new System.Drawing.Size(85, 23);
            this.加载.TabIndex = 15;
            this.加载.Text = "加载数据源";
            this.加载.UseVisualStyleBackColor = true;
            this.加载.Click += new System.EventHandler(this.加载_Click);
            // 
            // 结果
            // 
            this.结果.AcceptsReturn = true;
            this.结果.AcceptsTab = true;
            this.结果.Location = new System.Drawing.Point(100, 77);
            this.结果.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.结果.MaxLength = 2147483647;
            this.结果.Multiline = true;
            this.结果.Name = "结果";
            this.结果.ReadOnly = true;
            this.结果.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.结果.Size = new System.Drawing.Size(717, 501);
            this.结果.TabIndex = 14;
            // 
            // 作者
            // 
            this.作者.AutoSize = true;
            this.作者.Location = new System.Drawing.Point(397, 20);
            this.作者.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.作者.Name = "作者";
            this.作者.Size = new System.Drawing.Size(32, 17);
            this.作者.TabIndex = 13;
            this.作者.Text = "作者";
            // 
            // 搜索
            // 
            this.搜索.AutoSize = true;
            this.搜索.Location = new System.Drawing.Point(51, 50);
            this.搜索.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.搜索.Name = "搜索";
            this.搜索.Size = new System.Drawing.Size(44, 17);
            this.搜索.TabIndex = 12;
            this.搜索.Text = "搜索框";
            // 
            // 书名
            // 
            this.书名.AutoSize = true;
            this.书名.Location = new System.Drawing.Point(98, 20);
            this.书名.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.书名.Name = "书名";
            this.书名.Size = new System.Drawing.Size(32, 17);
            this.书名.TabIndex = 11;
            this.书名.Text = "书名";
            // 
            // 作者框
            // 
            this.作者框.Location = new System.Drawing.Point(399, 47);
            this.作者框.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.作者框.Name = "作者框";
            this.作者框.Size = new System.Drawing.Size(165, 23);
            this.作者框.TabIndex = 10;
            this.作者框.TextChanged += new System.EventHandler(this.作者框_TextChanged);
            // 
            // 搜索按钮
            // 
            this.搜索按钮.Location = new System.Drawing.Point(569, 47);
            this.搜索按钮.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.搜索按钮.Name = "搜索按钮";
            this.搜索按钮.Size = new System.Drawing.Size(75, 23);
            this.搜索按钮.TabIndex = 9;
            this.搜索按钮.Text = "搜索";
            this.搜索按钮.UseVisualStyleBackColor = true;
            this.搜索按钮.Click += new System.EventHandler(this.搜索按钮_Click);
            // 
            // 书名框
            // 
            this.书名框.Location = new System.Drawing.Point(100, 47);
            this.书名框.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.书名框.Name = "书名框";
            this.书名框.Size = new System.Drawing.Size(294, 23);
            this.书名框.TabIndex = 8;
            this.书名框.TextChanged += new System.EventHandler(this.书名框_TextChanged);
            // 
            // 生成
            // 
            this.生成.WorkerSupportsCancellation = true;
            this.生成.DoWork += new System.ComponentModel.DoWorkEventHandler(this.生成_DoWork);
            // 
            // 文件
            // 
            this.文件.FileName = "文件";
            // 
            // 检索书名
            // 
            this.检索书名.WorkerSupportsCancellation = true;
            this.检索书名.DoWork += new System.ComponentModel.DoWorkEventHandler(this.检索书名_DoWork);
            // 
            // 检索作者
            // 
            this.检索作者.WorkerSupportsCancellation = true;
            this.检索作者.DoWork += new System.ComponentModel.DoWorkEventHandler(this.检索作者_DoWork);
            // 
            // 输出
            // 
            this.输出.WorkerSupportsCancellation = true;
            this.输出.DoWork += new System.ComponentModel.DoWorkEventHandler(this.输出_DoWork);
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(649, 47);
            this.取消.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(75, 23);
            this.取消.TabIndex = 16;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 进度条
            // 
            this.进度条.Location = new System.Drawing.Point(12, 581);
            this.进度条.Name = "进度条";
            this.进度条.Size = new System.Drawing.Size(805, 23);
            this.进度条.TabIndex = 17;
            // 
            // 索引框
            // 
            this.索引框.Location = new System.Drawing.Point(12, 77);
            this.索引框.Multiline = true;
            this.索引框.Name = "索引框";
            this.索引框.ReadOnly = true;
            this.索引框.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.索引框.Size = new System.Drawing.Size(83, 498);
            this.索引框.TabIndex = 18;
            // 
            // 检索
            // 
            this.ClientSize = new System.Drawing.Size(840, 615);
            this.Controls.Add(this.索引框);
            this.Controls.Add(this.进度条);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.加载);
            this.Controls.Add(this.结果);
            this.Controls.Add(this.作者);
            this.Controls.Add(this.搜索);
            this.Controls.Add(this.书名);
            this.Controls.Add(this.作者框);
            this.Controls.Add(this.搜索按钮);
            this.Controls.Add(this.书名框);
            this.MaximizeBox = false;
            this.Name = "检索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 加载;
        private System.Windows.Forms.TextBox 结果;
        private System.Windows.Forms.Label 作者;
        private System.Windows.Forms.Label 搜索;
        private System.Windows.Forms.Label 书名;
        private System.Windows.Forms.TextBox 作者框;
        private System.Windows.Forms.Button 搜索按钮;
        private System.Windows.Forms.TextBox 书名框;
        private System.ComponentModel.BackgroundWorker 生成;
        private System.Windows.Forms.OpenFileDialog 文件;
        private System.ComponentModel.BackgroundWorker 检索书名;
        private System.ComponentModel.BackgroundWorker 检索作者;
        private System.ComponentModel.BackgroundWorker 输出;
        private Button 取消;
        private ProgressBar 进度条;
        private TextBox 索引框;
    }
}