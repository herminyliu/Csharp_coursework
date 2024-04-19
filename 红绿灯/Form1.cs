using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 红绿灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)  //初始化程序
        {
            Green.BackColor = Color.Green; 
            Yellow.BackColor = Color.Gray;
            Red.BackColor = Color.Gray;
            Countdown.Text = "6";
            Green.ReadOnly = true;
            Yellow.ReadOnly = true; 
            Red.ReadOnly = true;
            Countdown.ReadOnly = true;
            timer.Enabled = false;
            timer.Interval = 1000;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if(timer.Enabled == false)
                timer.Start();
            else
                timer.Stop();
        }
        private int flag = 1; //控制下面的三个if语句 不要一路滑下去了！！
        private void timer_Tick(object sender, EventArgs e)
        {
            flag = 1; //flag的作用就是让下面的三个if句一次tick只执行其中一个
            Countdown.Text = Convert.ToString(Convert.ToInt16(Countdown.Text) - 1); //倒计时减1
            if (Countdown.Text == "-1")  //这样倒计时那里会显示出“0”
            {                
                if (Green.BackColor == Color.Green && flag == 1)
                {
                    Green.BackColor = Color.Gray;
                    Yellow.BackColor = Color.Yellow;
                    Countdown.Text = "3";
                    flag = 0;
                }
                if (Yellow.BackColor == Color.Yellow && flag == 1)
                {
                    Yellow.BackColor = Color.Gray;
                    Red.BackColor = Color.Red;
                    Countdown.Text = "4";
                    flag = 0;
                }
                if (Red.BackColor == Color.Red && flag == 1)
                {
                    Red.BackColor = Color.Gray;
                    Green.BackColor = Color.Green;
                    Countdown.Text = "6";
                    flag = 0;
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
