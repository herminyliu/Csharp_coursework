
namespace WindowsFormsApp1
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
            this.Greenlight = new System.Windows.Forms.TextBox();
            this.Yellowlight = new System.Windows.Forms.TextBox();
            this.Redlight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Greenlight
            // 
            this.Greenlight.Location = new System.Drawing.Point(105, 58);
            this.Greenlight.Multiline = true;
            this.Greenlight.Name = "Greenlight";
            this.Greenlight.Size = new System.Drawing.Size(100, 100);
            this.Greenlight.TabIndex = 0;
            this.Greenlight.TextChanged += new System.EventHandler(this.Greenlight_TextChanged);
            // 
            // Yellowlight
            // 
            this.Yellowlight.Location = new System.Drawing.Point(292, 58);
            this.Yellowlight.Multiline = true;
            this.Yellowlight.Name = "Yellowlight";
            this.Yellowlight.Size = new System.Drawing.Size(100, 100);
            this.Yellowlight.TabIndex = 1;
            this.Yellowlight.TextChanged += new System.EventHandler(this.Yellowlight_TextChanged);
            // 
            // Redlight
            // 
            this.Redlight.Location = new System.Drawing.Point(480, 58);
            this.Redlight.Multiline = true;
            this.Redlight.Name = "Redlight";
            this.Redlight.Size = new System.Drawing.Size(100, 100);
            this.Redlight.TabIndex = 2;
            this.Redlight.TextChanged += new System.EventHandler(this.Redlight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "绿灯";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "黄灯";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "红灯";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Countdown
            // 
            this.Countdown.Location = new System.Drawing.Point(294, 200);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(100, 21);
            this.Countdown.TabIndex = 7;
            this.Countdown.TextChanged += new System.EventHandler(this.Countdown_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "倒计时";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Redlight);
            this.Controls.Add(this.Yellowlight);
            this.Controls.Add(this.Greenlight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Greenlight;
        private System.Windows.Forms.TextBox Yellowlight;
        private System.Windows.Forms.TextBox Redlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Countdown;
        private System.Windows.Forms.Label label4;
    }
}

