namespace 红绿灯
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Green = new System.Windows.Forms.TextBox();
            this.Yellow = new System.Windows.Forms.TextBox();
            this.Red = new System.Windows.Forms.TextBox();
            this.Countdown = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(62, 57);
            this.Green.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Green.Multiline = true;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(89, 84);
            this.Green.TabIndex = 0;
            this.Green.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(300, 57);
            this.Yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yellow.Multiline = true;
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(89, 84);
            this.Yellow.TabIndex = 1;
            this.Yellow.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(537, 57);
            this.Red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Red.Multiline = true;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(89, 84);
            this.Red.TabIndex = 2;
            this.Red.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Countdown
            // 
            this.Countdown.Location = new System.Drawing.Point(300, 193);
            this.Countdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Countdown.Multiline = true;
            this.Countdown.Name = "Countdown";
            this.Countdown.ReadOnly = true;
            this.Countdown.Size = new System.Drawing.Size(89, 24);
            this.Countdown.TabIndex = 3;
            this.Countdown.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(288, 253);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(113, 27);
            this.button.TabIndex = 4;
            this.button.Text = "开始/停止";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "绿色";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "黄色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "红色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "倒计时";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Green;
        private System.Windows.Forms.TextBox Yellow;
        private System.Windows.Forms.TextBox Red;
        private System.Windows.Forms.TextBox Countdown;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

