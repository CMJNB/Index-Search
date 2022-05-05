using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace 搜索
{
    public partial class 检索 : Form
    {
        string file0 = ".\\test.txt";
        int[] i1 = { -1 };
        private CancellationTokenSource 搜索_stop;

        public 检索()
        {
            InitializeComponent();
            生成 = new BackgroundWorker();

        }

        private void 搜索按钮_Click(object sender, EventArgs e)
        {
            搜索_stop = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(state => Out(搜索_stop.Token));

        }

        private void 加载_Click(object sender, EventArgs e)
        {
            if (文件.ShowDialog() == DialogResult.OK)
            {
                file0 = 文件.FileName;
                System.Diagnostics.Trace.WriteLine(file0);
                生成.DoWork += new DoWorkEventHandler(生成_DoWork);
                生成.RunWorkerAsync(this);

            }
            if (生成.IsBusy)
            {
                System.Diagnostics.Debug.WriteLine("正在生成");
            }
            System.Diagnostics.Debug.WriteLine("???");
        }

        private void 生成_DoWork(object sender, DoWorkEventArgs e)
        {
            ArrayList arr = new();
            arr.Add(1);
            System.Diagnostics.Debug.WriteLine("!!!");

            string file1Path = ".\\数据索引\\";
            //创建目录
            System.IO.Directory.CreateDirectory(file1Path);
            //打开流
            System.IO.StreamReader file = new(file0, Encoding.UTF8, true);
            //遍历所有行
            for (int n = 0; file.Peek() != -1; n++)
            {
                //把每一行塞进数组
                char[] chars = file.ReadLine().ToCharArray();
                char[] listChar;
                //把重复的元素删掉
                listChar = (chars.GroupBy(p => p).Select(p => p.Key).ToArray());
                //遍历数组
                for (int i = 0; i < listChar.Length; i++)
                {
                    //System.Diagnostics.Debug.WriteLine(listChar[i]);
                    //System.Diagnostics.Debug.WriteLine(listChar.ToArray().Length);
                    //如果没有这个元素的文件就创建
                    if (listChar[i] != '/' && listChar[i] != ':' && listChar[i] != '.' && listChar[i] != ' ' && listChar[i] != '?')
                    {
                        StreamWriter file1 = new(file1Path + listChar[i], true, Encoding.UTF8);
                        file1.WriteLine(n);
                        file1.Close();
                        file1.Dispose();
                    }
                }
            }
            file.Close();
            file.Dispose();
            System.Diagnostics.Debug.WriteLine("结束");
        }

        private void 书名框_TextChanged(object sender, EventArgs e)
        {
            if (!检索书名.IsBusy)
            {
                检索书名.DoWork += new DoWorkEventHandler(检索书名_DoWork);
                检索书名.RunWorkerAsync(this);
            }
            if (书名框.Text == "")
            {
                索引框.Text = "";
            }
        }

        private void 作者框_TextChanged(object sender, EventArgs e)
        {
            检索作者.DoWork += new DoWorkEventHandler(检索作者_DoWork);
            检索作者.RunWorkerAsync(this);
        }

        private void 检索书名_DoWork(object sender, DoWorkEventArgs e)
        {
            char[] chars = 书名框.Text.ToCharArray();
            char[] listChar;
            List<int> list = new();
            //把重复的元素删掉
            listChar = (chars.GroupBy(p => p).Select(p => p.Key).ToArray());
            try
            {
                for (int i = 0; i < listChar.Length; i++)
                {
                    if (listChar[i] != '/' && listChar[i] != ':' && listChar[i] != '.' && listChar[i] != ' ' && listChar[i] != '?')
                    {
                        StreamReader file2 = new(".\\数据索引\\" + listChar[i], Encoding.UTF8, true);
                        // 判断是否读完
                        while (!file2.EndOfStream)
                        {
                            int result = Convert.ToInt32(file2.ReadLine());
                            list.Add(result);
                        }
                        int[] i2 = list.ToArray();
                        i1 = i2.GroupBy(p => p).Select(p => p.Key).ToArray();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                this.BeginInvoke(new Action(() => 结果.Text = ""));
                return;
                throw;
            }
            catch (DirectoryNotFoundException)
            {
                return;
                throw;
            }

            this.BeginInvoke(new Action(() => 索引框.Text += i1.Length + Environment.NewLine));

        }

        private void 检索作者_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public void Out(CancellationToken sous)
        {
            StringBuilder sb = new();
            StreamReader reader = new(file0);
            System.Diagnostics.Debug.WriteLine("@");
            this.BeginInvoke(new Action(() => 进度条.Maximum = i1.Length));
            try
            {
                int k = 0;
                for (int j = 0; !reader.EndOfStream; j++)
                {
                    if (j == i1[k])
                    {
                        //System.Diagnostics.Debug.WriteLine(reader.ReadLine());
                        this.Invoke(new Action(() => 结果.Text += (k+1) + ":::" + reader.ReadLine() + Environment.NewLine));
                        k++;
                        this.BeginInvoke(new Action(() => 进度条.Value = k));
                        if (k == i1.Length || sous.IsCancellationRequested)
                        {
                            break;
                        }
                    }
                    else
                    {
                        reader.ReadLine();
                    }
                }
                reader.Close();
                reader.Dispose();
            }
            catch (NullReferenceException)
            {
                throw;
            }
        }

        private void 输出_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void 取消_Click(object sender, EventArgs e)
        {
            if (搜索_stop != null)
            {
                搜索_stop.Cancel();
                进度条.Value = 0;
                Array.Clear(i1);
            }
        }
    }
}

