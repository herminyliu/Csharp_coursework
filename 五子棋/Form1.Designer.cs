namespace 五子棋
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            存档ToolStripMenuItem = new ToolStripMenuItem();
            导入ToolStripMenuItem = new ToolStripMenuItem();
            导出ToolStripMenuItem = new ToolStripMenuItem();
            更多操作ToolStripMenuItem = new ToolStripMenuItem();
            悔棋ToolStripMenuItem = new ToolStripMenuItem();
            复盘ToolStripMenuItem = new ToolStripMenuItem();
            退出复盘ToolStripMenuItem = new ToolStripMenuItem();
            音乐ToolStripMenuItem = new ToolStripMenuItem();
            背景ToolStripMenuItem = new ToolStripMenuItem();
            经典ToolStripMenuItem = new ToolStripMenuItem();
            淡雅ToolStripMenuItem = new ToolStripMenuItem();
            清新ToolStripMenuItem = new ToolStripMenuItem();
            原木ToolStripMenuItem = new ToolStripMenuItem();
            复盘速度ToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem1 = new ToolStripMenuItem();
            sToolStripMenuItem2 = new ToolStripMenuItem();
            sToolStripMenuItem3 = new ToolStripMenuItem();
            sToolStripMenuItem4 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            OperationRecord = new TextBox();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ReviewTimer = new System.Windows.Forms.Timer(components);
            Pause = new Button();
            Start = new Button();
            Restart = new Button();
            Exit = new Button();
            usedTime = new TextBox();
            label4 = new Label();
            PlayTimer = new System.Windows.Forms.Timer(components);
            Resume = new Button();
            DateAndTime = new Label();
            DateAndTimeTimer = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 53);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(516, 506);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 存档ToolStripMenuItem, 更多操作ToolStripMenuItem, 音乐ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1037, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // 存档ToolStripMenuItem
            // 
            存档ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 导入ToolStripMenuItem, 导出ToolStripMenuItem });
            存档ToolStripMenuItem.Name = "存档ToolStripMenuItem";
            存档ToolStripMenuItem.Size = new Size(71, 24);
            存档ToolStripMenuItem.Text = "存档(&F)";
            // 
            // 导入ToolStripMenuItem
            // 
            导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            导入ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            导入ToolStripMenuItem.Size = new Size(183, 26);
            导入ToolStripMenuItem.Text = "导入";
            导入ToolStripMenuItem.Click += 导入ToolStripMenuItem_Click;
            // 
            // 导出ToolStripMenuItem
            // 
            导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            导出ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
            导出ToolStripMenuItem.Size = new Size(183, 26);
            导出ToolStripMenuItem.Text = "导出";
            导出ToolStripMenuItem.Click += 导出ToolStripMenuItem_Click;
            // 
            // 更多操作ToolStripMenuItem
            // 
            更多操作ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 悔棋ToolStripMenuItem, 复盘ToolStripMenuItem, 退出复盘ToolStripMenuItem });
            更多操作ToolStripMenuItem.Name = "更多操作ToolStripMenuItem";
            更多操作ToolStripMenuItem.Size = new Size(105, 24);
            更多操作ToolStripMenuItem.Text = "更多操作(&O)";
            // 
            // 悔棋ToolStripMenuItem
            // 
            悔棋ToolStripMenuItem.Name = "悔棋ToolStripMenuItem";
            悔棋ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            悔棋ToolStripMenuItem.Size = new Size(206, 26);
            悔棋ToolStripMenuItem.Text = "悔棋";
            悔棋ToolStripMenuItem.Click += 悔棋ToolStripMenuItem_Click;
            // 
            // 复盘ToolStripMenuItem
            // 
            复盘ToolStripMenuItem.Name = "复盘ToolStripMenuItem";
            复盘ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            复盘ToolStripMenuItem.Size = new Size(206, 26);
            复盘ToolStripMenuItem.Text = "复盘";
            复盘ToolStripMenuItem.Click += 复盘ToolStripMenuItem_Click;
            // 
            // 退出复盘ToolStripMenuItem
            // 
            退出复盘ToolStripMenuItem.Name = "退出复盘ToolStripMenuItem";
            退出复盘ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            退出复盘ToolStripMenuItem.Size = new Size(206, 26);
            退出复盘ToolStripMenuItem.Text = "退出复盘";
            退出复盘ToolStripMenuItem.Visible = false;
            退出复盘ToolStripMenuItem.Click += 退出复盘ToolStripMenuItem_Click;
            // 
            // 音乐ToolStripMenuItem
            // 
            音乐ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 背景ToolStripMenuItem, 复盘速度ToolStripMenuItem });
            音乐ToolStripMenuItem.Name = "音乐ToolStripMenuItem";
            音乐ToolStripMenuItem.Size = new Size(72, 24);
            音乐ToolStripMenuItem.Text = "设置(&S)";
            // 
            // 背景ToolStripMenuItem
            // 
            背景ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 经典ToolStripMenuItem, 淡雅ToolStripMenuItem, 清新ToolStripMenuItem, 原木ToolStripMenuItem });
            背景ToolStripMenuItem.Name = "背景ToolStripMenuItem";
            背景ToolStripMenuItem.Size = new Size(152, 26);
            背景ToolStripMenuItem.Text = "背景";
            // 
            // 经典ToolStripMenuItem
            // 
            经典ToolStripMenuItem.Name = "经典ToolStripMenuItem";
            经典ToolStripMenuItem.Size = new Size(122, 26);
            经典ToolStripMenuItem.Text = "经典";
            经典ToolStripMenuItem.Click += 经典ToolStripMenuItem_Click;
            // 
            // 淡雅ToolStripMenuItem
            // 
            淡雅ToolStripMenuItem.Name = "淡雅ToolStripMenuItem";
            淡雅ToolStripMenuItem.Size = new Size(122, 26);
            淡雅ToolStripMenuItem.Text = "淡雅";
            淡雅ToolStripMenuItem.Click += 淡雅ToolStripMenuItem_Click;
            // 
            // 清新ToolStripMenuItem
            // 
            清新ToolStripMenuItem.Name = "清新ToolStripMenuItem";
            清新ToolStripMenuItem.Size = new Size(122, 26);
            清新ToolStripMenuItem.Text = "清新";
            清新ToolStripMenuItem.Click += 清新ToolStripMenuItem_Click;
            // 
            // 原木ToolStripMenuItem
            // 
            原木ToolStripMenuItem.Name = "原木ToolStripMenuItem";
            原木ToolStripMenuItem.Size = new Size(122, 26);
            原木ToolStripMenuItem.Text = "原木";
            原木ToolStripMenuItem.Click += 原木ToolStripMenuItem_Click;
            // 
            // 复盘速度ToolStripMenuItem
            // 
            复盘速度ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sToolStripMenuItem, sToolStripMenuItem1, sToolStripMenuItem2, sToolStripMenuItem3, sToolStripMenuItem4 });
            复盘速度ToolStripMenuItem.Name = "复盘速度ToolStripMenuItem";
            复盘速度ToolStripMenuItem.Size = new Size(152, 26);
            复盘速度ToolStripMenuItem.Text = "复盘速度";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Checked = true;
            sToolStripMenuItem.CheckState = CheckState.Checked;
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(130, 26);
            sToolStripMenuItem.Text = "0.5s";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // sToolStripMenuItem1
            // 
            sToolStripMenuItem1.Checked = true;
            sToolStripMenuItem1.CheckState = CheckState.Checked;
            sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            sToolStripMenuItem1.Size = new Size(130, 26);
            sToolStripMenuItem1.Text = "1s";
            sToolStripMenuItem1.Click += sToolStripMenuItem1_Click;
            // 
            // sToolStripMenuItem2
            // 
            sToolStripMenuItem2.Checked = true;
            sToolStripMenuItem2.CheckState = CheckState.Checked;
            sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            sToolStripMenuItem2.Size = new Size(130, 26);
            sToolStripMenuItem2.Text = "1.5s";
            sToolStripMenuItem2.Click += sToolStripMenuItem2_Click;
            // 
            // sToolStripMenuItem3
            // 
            sToolStripMenuItem3.Checked = true;
            sToolStripMenuItem3.CheckState = CheckState.Checked;
            sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            sToolStripMenuItem3.Size = new Size(130, 26);
            sToolStripMenuItem3.Text = "1.75s";
            sToolStripMenuItem3.Click += sToolStripMenuItem3_Click;
            // 
            // sToolStripMenuItem4
            // 
            sToolStripMenuItem4.Checked = true;
            sToolStripMenuItem4.CheckState = CheckState.Checked;
            sToolStripMenuItem4.Name = "sToolStripMenuItem4";
            sToolStripMenuItem4.Size = new Size(130, 26);
            sToolStripMenuItem4.Text = "2s";
            sToolStripMenuItem4.Click += sToolStripMenuItem4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "当前落子为：黑子";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "已经下了：0手";
            // 
            // OperationRecord
            // 
            OperationRecord.Location = new Point(533, 53);
            OperationRecord.Margin = new Padding(2);
            OperationRecord.Multiline = true;
            OperationRecord.Name = "textBox1";
            OperationRecord.ReadOnly = true;
            OperationRecord.ScrollBars = ScrollBars.Vertical;
            OperationRecord.Size = new Size(286, 506);
            OperationRecord.TabIndex = 6;
            OperationRecord.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(715, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 7;
            label3.Text = "操作记录栏";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReviewTimer
            // 
            ReviewTimer.Tick += ReviewTimer_Tick;
            // 
            // Pause
            // 
            Pause.Location = new Point(824, 196);
            Pause.Margin = new Padding(2);
            Pause.Name = "Pause";
            Pause.Size = new Size(92, 28);
            Pause.TabIndex = 8;
            Pause.Text = "暂停游戏";
            Pause.UseVisualStyleBackColor = true;
            Pause.Click += Pause_Click;
            // 
            // Start
            // 
            Start.Location = new Point(824, 196);
            Start.Margin = new Padding(2);
            Start.Name = "Start";
            Start.Size = new Size(92, 28);
            Start.TabIndex = 9;
            Start.Text = "开始游戏";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Restart
            // 
            Restart.Location = new Point(824, 241);
            Restart.Margin = new Padding(2);
            Restart.Name = "Restart";
            Restart.Size = new Size(92, 28);
            Restart.TabIndex = 10;
            Restart.Text = "重新开始";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(824, 288);
            Exit.Margin = new Padding(2);
            Exit.Name = "Exit";
            Exit.Size = new Size(92, 28);
            Exit.TabIndex = 11;
            Exit.Text = "退出游戏";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // usedTime
            // 
            usedTime.Location = new Point(824, 155);
            usedTime.Margin = new Padding(2);
            usedTime.Name = "usedTime";
            usedTime.ReadOnly = true;
            usedTime.Size = new Size(83, 27);
            usedTime.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(824, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 13;
            label4.Text = "已对弈时间";
            // 
            // PlayTimer
            // 
            PlayTimer.Tick += timer2_Tick;
            // 
            // Resume
            // 
            Resume.Location = new Point(824, 196);
            Resume.Margin = new Padding(2);
            Resume.Name = "Resume";
            Resume.Size = new Size(92, 28);
            Resume.TabIndex = 16;
            Resume.Text = "继续游戏";
            Resume.UseVisualStyleBackColor = true;
            Resume.Click += Resume_Click;
            // 
            // DateAndTime
            // 
            DateAndTime.AutoSize = true;
            DateAndTime.Location = new Point(254, 31);
            DateAndTime.Margin = new Padding(2, 0, 2, 0);
            DateAndTime.Name = "DateAndTime";
            DateAndTime.Size = new Size(53, 20);
            DateAndTime.TabIndex = 17;
            DateAndTime.Text = "label6";
            // 
            // DateAndTimeTimer
            // 
            DateAndTimeTimer.Tick += DateAndTimeTimer_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("华文楷体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(824, 346);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 22);
            label5.TabIndex = 18;
            label5.Text = "刘般若 化生2101";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 569);
            Controls.Add(label5);
            Controls.Add(DateAndTime);
            Controls.Add(Resume);
            Controls.Add(label4);
            Controls.Add(usedTime);
            Controls.Add(Exit);
            Controls.Add(Restart);
            Controls.Add(Start);
            Controls.Add(Pause);
            Controls.Add(label3);
            Controls.Add(OperationRecord);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "五子棋";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 存档ToolStripMenuItem;
        private ToolStripMenuItem 导入ToolStripMenuItem;
        private ToolStripMenuItem 导出ToolStripMenuItem;
        private ToolStripMenuItem 更多操作ToolStripMenuItem;
        private ToolStripMenuItem 悔棋ToolStripMenuItem;
        private ToolStripMenuItem 复盘ToolStripMenuItem;
        private ToolStripMenuItem 音乐ToolStripMenuItem;
        private ToolStripMenuItem 背景ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox OperationRecord;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer ReviewTimer;
        private Button Pause;
        private Button Start;
        private Button Restart;
        private Button Exit;
        private ToolStripMenuItem 退出复盘ToolStripMenuItem;
        private TextBox usedTime;
        private Label label4;
        private System.Windows.Forms.Timer PlayTimer;
        private ToolStripMenuItem 经典ToolStripMenuItem;
        private ToolStripMenuItem 淡雅ToolStripMenuItem;
        private ToolStripMenuItem 清新ToolStripMenuItem;
        private ToolStripMenuItem 复盘速度ToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem1;
        private ToolStripMenuItem sToolStripMenuItem2;
        private ToolStripMenuItem sToolStripMenuItem3;
        private ToolStripMenuItem sToolStripMenuItem4;
        private Button Resume;
        private Label DateAndTime;
        private System.Windows.Forms.Timer DateAndTimeTimer;
        private ToolStripMenuItem 原木ToolStripMenuItem;
        private Label label5;
    }
}