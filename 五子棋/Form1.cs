using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace 五子棋
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Record2DArray[i, j] = 0;
                }
            }
            ReviewTimer.Interval = 1500;
            PlayTimer.Interval = 1000;
            DateAndTimeTimer.Start();
            sToolStripMenuItem.Checked = false;
            sToolStripMenuItem1.Checked = false;
            sToolStripMenuItem2.Checked = true;
            sToolStripMenuItem3.Checked = false;
            sToolStripMenuItem4.Checked = false;
            pictureBox1.BackColor = Color.FromArgb(205, 155, 29);
            pictureBox1.Enabled = false;
            Start.Visible = true;
            Pause.Visible = false;
            Resume.Visible = false;
            OperationRecord.Text = OperationRecord.Text + "欢迎进入五子棋对弈系统！请按“开始游戏”按钮开始下棋\r\n";
            usedTime.Text = "00:00:00";
            //player.SoundLocation = @"C:\Users\1\source\repos\五子棋\五子棋\bin\Debug\net6.0-windows\落子.m4a";
            //player.Load(); //这两行没啥用了，放在这里做个纪念


        }

        const int squarewidth = 40;
        const int linewidth = 2;
        const int boldLinewidth = 4;
        const int margin = 30;
        const int diameter = 25;
        const int diameter2 = 10;
        List<Point> DrawPointsArray = new List<Point>(); //绘图数组 List<Point> DrawPointsArray
        List<Point> RecordPointsArray = new List<Point>();
        int[,] Record2DArray = new int[15, 15];//初始值默认为0 
        int count = 0;
        int reviewCount = 0;
        string saveOfTextBox1;
        DateTime TimeNow = new DateTime();
        TimeSpan TimeCount = new TimeSpan();
        TimeSpan TimeSpanRecord = new TimeSpan();
        bool IsEnd = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OperationRecord.SelectionStart = OperationRecord.Text.Length;
            OperationRecord.ScrollToCaret();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)  //绘图程序
        {
            Graphics g = e.Graphics;
            Pen DrawLinesP = new Pen(Color.Black, linewidth);
            Pen DrawLinesBoldP = new Pen(Color.Black, boldLinewidth);
            for (int i = 0; i < 15; i++)
            {
                g.DrawLine(DrawLinesP, margin + i * squarewidth, margin, margin + i * squarewidth, margin + 14 * squarewidth);
                g.DrawLine(DrawLinesP, margin, margin + i * squarewidth, margin + 14 * squarewidth, margin + i * squarewidth);
            }
            g.DrawRectangle(DrawLinesBoldP, margin - 5, margin - 5, squarewidth * 14 + 10, squarewidth * 14 + 10);
            Brush BrushWhite = new SolidBrush(Color.White);
            Brush BrushBlack = new SolidBrush(Color.Black);

            g.FillEllipse(BrushBlack, margin + squarewidth * 3 - diameter2 / 2, margin + squarewidth * 3 - diameter2 / 2, diameter2, diameter2);
            g.FillEllipse(BrushBlack, margin + squarewidth * 11 - diameter2 / 2, margin + squarewidth * 11 - diameter2 / 2, diameter2, diameter2);
            g.FillEllipse(BrushBlack, margin + squarewidth * 3 - diameter2 / 2, margin + squarewidth * 11 - diameter2 / 2, diameter2, diameter2);
            g.FillEllipse(BrushBlack, margin + squarewidth * 11 - diameter2 / 2, margin + squarewidth * 3 - diameter2 / 2, diameter2, diameter2);
            g.FillEllipse(BrushBlack, margin + squarewidth * 7 - diameter2 / 2, margin + squarewidth * 7 - diameter2 / 2, diameter2, diameter2);
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    g.FillEllipse(BrushBlack, DrawPointsArray[i].X, DrawPointsArray[i].Y, diameter, diameter);
                }
                else
                {
                    g.FillEllipse(BrushWhite, DrawPointsArray[i].X, DrawPointsArray[i].Y, diameter, diameter);
                }
            }
        }

        bool flag = true;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)  //鼠标点击程序
        {
            Point temp = new Point(e.X, e.Y);
            temp = AdjustLocation(temp);
            Point temp2 = new Point((temp.X - margin + diameter / 2) / squarewidth + 1, (temp.Y - margin + diameter / 2) / squarewidth + 1);
            flag = true;
            for (int i = 0; i < count; i++)
            {
                if (DrawPointsArray[i] == temp || temp2.X > 15 || temp2.Y > 15)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                DrawPointsArray.Add(temp);
                RecordPointsArray.Add(temp2);

                if (count % 2 == 0)
                {
                    OperationRecord.Text = OperationRecord.Text + "第" + (count + 1) + "子 黑 " + temp2.Y + "行 " + temp2.X + "列\r\n";
                    label1.Text = "当前落子为：黑子";
                    Record2DArray[temp2.Y - 1, temp2.X - 1] = 1;//在数组上记录
                }
                else
                {
                    OperationRecord.Text = OperationRecord.Text + "第" + (count + 1) + "子 白 " + temp2.Y + "行 " + temp2.X + "列\r\n";//这个行列显示还需要继续改
                    label1.Text = "当前落子为：白子";
                    Record2DArray[temp2.Y - 1, temp2.X - 1] = 2;//在数组上记录
                }
                count++;
                label2.Text = "已经下了" + count + "手";

                pictureBox1.Invalidate();

                if (Win(temp2.Y - 1, temp2.X - 1, 1, 0) || Win(temp2.Y - 1, temp2.X - 1, 0, 1) || Win(temp2.Y - 1, temp2.X - 1, 1, 1) || Win(temp2.Y - 1, temp2.X - 1, 1, -1))
                {
                    SystemSounds.Exclamation.Play();
                    PlayTimer.Stop();
                    IsEnd = true;
                    if (Record2DArray[temp2.Y - 1, temp2.X - 1] == 1)
                    {
                        OperationRecord.Text = OperationRecord.Text + "黑棋获胜\r\n";
                        MessageBox.Show("黑棋获胜");

                    }
                    else
                    {
                        OperationRecord.Text = OperationRecord.Text + "白棋获胜\r\n";
                        MessageBox.Show("白棋获胜");
                    }
                    悔棋ToolStripMenuItem.Enabled = false;
                    OperationRecord.Text = OperationRecord.Text + "对弈总用时：" + usedTime.Text + "\r\n";
                    pictureBox1.Enabled = false;
                    Pause.Enabled = false; //让“暂停游戏”那个按钮变成灰色                    
                }
            }
        }
        public Point AdjustLocation(Point p) //对棋子位置的修正
        {
            if ((p.X - margin) / (double)squarewidth - ((p.X - margin) / squarewidth) > 0.5)
                p.X = ((p.X - margin) / squarewidth + 1) * squarewidth + margin - diameter / 2;
            else
                p.X = (p.X - margin) / squarewidth * squarewidth + margin - diameter / 2;

            if ((p.Y - margin) / (double)squarewidth - ((p.Y - margin) / squarewidth) > 0.5)
                p.Y = ((p.Y - margin) / squarewidth + 1) * squarewidth + margin - diameter / 2;
            else
                p.Y = (p.Y - margin) / squarewidth * squarewidth + margin - diameter / 2;

            //等价写法：Point resP = new Point(45 + (int)((p.X - 45) / 35.0 + 1.0 / 2) * 35, 45 + (int)((p.Y - 45) / 35.0 + 1.0 / 2) * 35);            
            return p;
        }

        public bool Win(int x, int y, int Xdir, int Ydir) //搜索是否五个棋子横着连在一起或者斜着连在一起
        {
            //构建一个二维数组，表征棋盘上面有无棋子，什么颜色棋子。
            //约定：没有棋子为0 白棋为1 黑棋为2
            int type = Record2DArray[x, y];
            int inLine = 0;
            int Xmin = x - 4 * Xdir; //注意，这里的max min是相对的，当XYdir为负数的时候反转
            int Xmax = x + 4 * Xdir;
            int Ymin = y - 4 * Ydir;
            int Ymax = y + 4 * Ydir;
            Point pointMax = new Point(Xmax, Ymax);
            Point pointMin = new Point(Xmin, Ymin);
            int searchMax = 5;
            int searchMin = -4;
            if (true)
            {
                if (pointMax.X < 0)
                {
                    if (searchMax > pointMax.X + 4)
                        searchMax = pointMax.X + 4;
                }
                if (pointMin.X < 0)
                {
                    if (searchMin < -pointMin.X - 4)
                        searchMin = -pointMin.X - 4;
                }
                if (pointMax.X > 14)
                {
                    if (searchMax > 18 - pointMax.X)// 4 - (pointMax -14)
                        searchMax = 18 - pointMax.X;

                }
                if (pointMin.X > 14)
                {
                    if (searchMin < -4 + pointMin.X - 14)
                        searchMin = pointMin.X - 18;
                }
                if (pointMax.Y < 0)
                {
                    if (searchMax > pointMax.Y + 4)
                        searchMax = pointMax.Y + 4;
                }
                if (pointMin.Y < 0)
                {
                    if (searchMin < -pointMin.Y - 4)
                        searchMin = -pointMin.Y - 4;
                }
                if (pointMax.Y > 14)
                {
                    if (searchMax > 4 - (pointMax.Y - 14))
                        searchMax = 18 - (pointMax.Y);
                }
                if (pointMin.Y > 14)
                {
                    if (searchMin < pointMin.Y - 14 - 4)
                        searchMin = pointMin.Y - 18;
                }
            }
            if (searchMax < 1)
                searchMax = 1;
            for (int i = searchMin; i < searchMax; i++) // 应该给searchMax划定一个最小值1，给searchMin划定一个最大值0
            {
                if (Record2DArray[x + i * Xdir, y + i * Ydir] == type)
                {
                    inLine++;
                }
                else
                {
                    inLine = 0;
                }
                if (inLine >= 5)
                {
                    break;
                }
            }
            return inLine >= 5;
        }

        private void 悔棋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            if (count - 1 < 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("没有可以悔的棋！");
            }
            else
            {
                Record2DArray[RecordPointsArray[count - 1].X - 1, RecordPointsArray[count - 1].Y - 1] = 0;
                DrawPointsArray.RemoveAt(count - 1);
                RecordPointsArray.RemoveAt(count - 1);
                count--;
                OperationRecord.Text = OperationRecord.Text + "悔棋一次" + " 悔掉的是第" + (count + 1) + "手\r\n";
                label2.Text = "已经下了" + count + "手";
                pictureBox1.Invalidate();
            }
        }

        private void 复盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("还未落一子，无法复盘！");
            }
            else
            {
                TimeSpanRecord = DateTime.Now - TimeNow;
                PlayTimer.Stop();
                reviewCount = count;
                count = 0;
                saveOfTextBox1 = OperationRecord.Text;
                OperationRecord.Clear();
                OperationRecord.Text = "欢迎进入五子棋对弈系统！请按“开始游戏”按钮开始下棋\r\n";
                ReviewTimer.Start();
                复盘ToolStripMenuItem.Visible = false;
                悔棋ToolStripMenuItem.Visible = false;
                退出复盘ToolStripMenuItem.Visible = true;
                Restart.Enabled = false;
                Pause.Enabled = false;
                usedTime.Text = "";
                pictureBox1.Invalidate();
            }
        }

        private void 退出复盘ToolStripMenuItem_Click(object sender, EventArgs e) //能点击这个按钮一定是在复盘状态下
        {
            ReviewTimer.Stop();
            TimeNow = DateTime.Now - TimeSpanRecord;
            count = reviewCount;
            pictureBox1.Invalidate();
            OperationRecord.Text = saveOfTextBox1;
            复盘ToolStripMenuItem.Visible = true;
            悔棋ToolStripMenuItem.Visible = true;
            退出复盘ToolStripMenuItem.Visible = false;
            pictureBox1.Enabled = false;
            Restart.Enabled = true;

            if (IsEnd == false)
            {
                Resume.Visible = true;
                Pause.Visible = false;
                Pause.Enabled = true;
                OperationRecord.Text = OperationRecord.Text + "复盘中断，请按“继续游戏”按钮继续对弈\r\n";
            }
            else
            {
                Resume.Visible = false;
                OperationRecord.Text = OperationRecord.Text + "复盘中断，请按“重新开始”按钮重新开始一局，或者按“退出游戏”按钮退出游戏\r\n";
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Start_Click(object sender, EventArgs e)  //点击开始游戏按钮
        {
            pictureBox1.Enabled = true;
            Start.Visible = false;
            Resume.Visible = false;
            Pause.Visible = true;
            OperationRecord.Text = OperationRecord.Text + "开始对弈\r\n";
            TimeNow = DateTime.Now;
            PlayTimer.Start();
        }

        private void Pause_Click(object sender, EventArgs e)  //点击暂停游戏按钮
        {
            pictureBox1.Enabled = false;
            Resume.Visible = true;
            Pause.Visible = false;
            PlayTimer.Stop();
            TimeSpanRecord = DateTime.Now - TimeNow; //TimeTemp为负数！
            OperationRecord.Text = OperationRecord.Text + "暂停对弈，已用时：" + usedTime.Text + "\r\n";
        }

        private void Resume_Click(object sender, EventArgs e)  //点击继续游戏按钮
        {
            pictureBox1.Enabled = true;
            Resume.Visible = false;
            Pause.Visible = true;
            OperationRecord.Text = OperationRecord.Text + "继续对弈\r\n";
            TimeNow = DateTime.Now - TimeSpanRecord;
            PlayTimer.Start();
        }

        private void Restart_Click(object sender, EventArgs e)  // 点击重新开始按钮
        {
            PlayTimer.Stop();
            count = 0;
            OperationRecord.Clear();
            OperationRecord.Text = "欢迎进入五子棋对弈系统！请按“开始游戏”按钮开始下棋\r\n";
            DrawPointsArray.RemoveRange(0, DrawPointsArray.Count);
            RecordPointsArray.RemoveRange(0, RecordPointsArray.Count);
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Record2DArray[i, j] = 0;
                }
            }
            label2.Text = "已经下了0手";
            label1.Text = "当前落子为：黑子";
            usedTime.Text = "00:00:00";
            Start.Visible = true;
            Pause.Visible = true;
            Resume.Visible = false;
            pictureBox1.Enabled = false;
            Pause.Enabled = true;
            pictureBox1.Invalidate();
            TimeNow = DateTime.Now; //相当于计时器重置为0
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeCount = DateTime.Now - TimeNow;
            usedTime.Text = string.Format("{0:00}:{1:00}:{2:00}",
                TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);
        }

        Gomoku myChessBoard = new Gomoku();

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "五子棋棋局 | *.wzq"; //文件类型自定义

            myChessBoard.textRecord = OperationRecord.Text;
            myChessBoard.position = Record2DArray;
            myChessBoard.count = count;
            myChessBoard.chesspieces = DrawPointsArray;
            myChessBoard.adjustedchesspieces = RecordPointsArray;
            myChessBoard.TimeCount = TimeCount;
            PlayTimer.Stop(); //避免用户在选择文件路径是那个计时器还在动来动去

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName + ".wzq", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    saveFileDialog1.Title = "请选择您要保存的路径和命名文件名";
                    bf.Serialize(fs, myChessBoard); //将对象myChessBoard序列化后存入文件saveFileDialog1.FileName
                    fs.Close();
                    OperationRecord.Text = OperationRecord.Text + "文件导出成功！\r\n";
                    MessageBox.Show("导出成功！");
                    PlayTimer.Start();
                }
                catch
                {
                    MessageBox.Show("导出失败！");
                }
            }
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //利用打开文件对话框，指定所选文件的路径、文件名和文件类型
            openFileDialog1.Filter = "五子棋棋局|*.wzq";
            openFileDialog1.Title = "请选择要导入的文件的地址";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    myChessBoard = (Gomoku)bf.Deserialize(fs); //将文件内容反序列化为对象
                    Initialize(myChessBoard);
                    fs.Close();
                    pictureBox1.Enabled = true;
                    pictureBox1.Invalidate();
                    悔棋ToolStripMenuItem.Enabled = true;
                    MessageBox.Show("导入成功");
                    OperationRecord.Text = OperationRecord.Text + "文件导入成功！\r\n";
                    PlayTimer.Start();
                }
                catch
                {
                    MessageBox.Show("导入失败");
                }
            }
        }

        public void Initialize(Gomoku input)
        {
            count = input.count;
            OperationRecord.Text = input.textRecord;
            Record2DArray = input.position;
            DrawPointsArray = input.chesspieces;
            RecordPointsArray = input.adjustedchesspieces;
            TimeNow = DateTime.Now - input.TimeCount; //把保存的残局的已对弈时间也保存下来
        }

        private void 经典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.FromArgb(205, 155, 29);
        }

        private void 淡雅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.LightGray;
        }

        private void 清新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.AliceBlue;
        }
        private void 原木ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string appPath = System.Windows.Forms.Application.StartupPath; 返回的值是：..\五子棋\bin\Debug\net6.0-windows\ 可见这个工作文件夹藏得很深
            if (System.IO.File.Exists(@"..\..\..\原木.jpg")) // 相对路径需要向上索引三个文件夹
            {
                Image img = Image.FromFile(@"..\..\..\原木.jpg");
                pictureBox1.Image = img;
            }

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTimer.Interval = 500;
            sToolStripMenuItem.Checked = true;
            sToolStripMenuItem1.Checked = false;
            sToolStripMenuItem2.Checked = false;
            sToolStripMenuItem3.Checked = false;
            sToolStripMenuItem4.Checked = false;
        }

        private void sToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReviewTimer.Interval = 1000;
            sToolStripMenuItem.Checked = false;
            sToolStripMenuItem1.Checked = true;
            sToolStripMenuItem2.Checked = false;
            sToolStripMenuItem3.Checked = false;
            sToolStripMenuItem4.Checked = false;

        }

        private void sToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReviewTimer.Interval = 1500;
            sToolStripMenuItem.Checked = false;
            sToolStripMenuItem1.Checked = false;
            sToolStripMenuItem2.Checked = true;
            sToolStripMenuItem3.Checked = false;
            sToolStripMenuItem4.Checked = false;
        }

        private void sToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ReviewTimer.Interval = 1750;
            sToolStripMenuItem.Checked = false;
            sToolStripMenuItem1.Checked = false;
            sToolStripMenuItem2.Checked = false;
            sToolStripMenuItem3.Checked = true;
            sToolStripMenuItem4.Checked = false;
        }

        private void sToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ReviewTimer.Interval = 2000;
            sToolStripMenuItem.Checked = false;
            sToolStripMenuItem1.Checked = false;
            sToolStripMenuItem2.Checked = false;
            sToolStripMenuItem3.Checked = false;
            sToolStripMenuItem4.Checked = true;
        }
        //棋子大小不能随便调！
        //因为diameter变量还会影响到棋子所在行列的判定!
        //如果变量前后不一致的话可能会在同一地点重复落子！

        DateTime TellDateAndTime = new DateTime();
        private void DateAndTimeTimer_Tick(object sender, EventArgs e)
        {
            TellDateAndTime = DateTime.Now;

            DateAndTime.Text = string.Format("{0}年{1}月{2}日 {3} {4:00}:{5:00}:{6:00}",
                TellDateAndTime.Year, TellDateAndTime.Month, TellDateAndTime.Day, TellDateAndTime.DayOfWeek,
                TellDateAndTime.Hour, TellDateAndTime.Minute, TellDateAndTime.Second);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [Serializable] //最后的序列化部分，这个类一定要放在最后面
        public class Gomoku
        {
            public int[,] position = new int[15, 15];//初始值默认为0     
            public int count = 0;
            public string textRecord;
            public List<Point> chesspieces = new List<Point>();
            public List<Point> adjustedchesspieces = new List<Point>();
            public TimeSpan TimeCount;

        }

        private void ReviewTimer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();   //第一次是只画棋盘
            if (count % 2 == 0)
            {
                OperationRecord.Text = OperationRecord.Text + "第" + (count + 1) + "子 黑 " + RecordPointsArray[count].Y + "行 " + RecordPointsArray[count].X + "列\r\n";
                label1.Text = "当前落子为：黑子";
            }
            else
            {
                OperationRecord.Text = OperationRecord.Text + "第" + (count + 1) + "子 白 " + RecordPointsArray[count].Y + "行 " + RecordPointsArray[count].X + "列\r\n";
                label1.Text = "当前落子为：白子";
            }
            count++;
            label2.Text = "已经下了" + count + "手";
            if (count == reviewCount)
            {
                ReviewTimer.Stop();
                MessageBox.Show("复盘完毕！");
                复盘ToolStripMenuItem.Visible = true;
                悔棋ToolStripMenuItem.Visible = true;
                退出复盘ToolStripMenuItem.Visible = false;
                TimeNow = DateTime.Now - TimeSpanRecord;
                pictureBox1.Enabled = false;
                Restart.Enabled = true;
                if (IsEnd == false)
                {
                    Resume.Visible = true;
                    Pause.Visible = false;
                    Pause.Enabled = true;
                    OperationRecord.Text = OperationRecord.Text + "复盘完毕，请按“继续游戏”按钮继续对弈\r\n";
                }
                else
                {
                    Resume.Visible = false;
                    OperationRecord.Text = OperationRecord.Text + "复盘完毕，请按“重新开始”按钮重新开始一局，或者按“退出游戏”按钮退出游戏\r\n";
                }
            }
        }
    }
    //C#窗体中只能由一个类！！[Serializable]public class Gomoku也需要保持在class Form1里面，不然保存的时候会触发“应有两个或多个类部件”弹窗报错
}