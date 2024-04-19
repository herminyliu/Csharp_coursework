using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int flag = 0;
        static int green = 0;
        static int yellow = 0;
        static int red = 0;

        public Form1()
        {
            
            InitializeComponent();
            Greenlight.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Yellowlight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Greenlight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Redlight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == 0)
                flag = 1;
            else
                flag = 0;
        }

        private void Countdown_TextChanged(object sender, EventArgs e)
        {
            while (true)
            {
                Greenlight.BackColor = Color.Green;

                for (int i = 6; i > 0; i--)
                {
                    if (flag == 0)
                        break;
                    Countdown.Text = Convert.ToString(i);
                    Thread.Sleep(1000);
                    
                }
                Greenlight.BackColor = Color.Gray;
                Yellowlight.BackColor = Color.Yellow;
                for (int i = 3; i > 0; i--)
                {
                    if (flag == 0)
                        break;
                    Countdown.Text = Convert.ToString(i);
                    Thread.Sleep(1000);
                    
                }
                Yellowlight.BackColor = Color.Gray;
                Redlight.BackColor = Color.Red;
                for (int i = 4; i > 0; i--)
                {
                    
                    if (flag == 0)
                        break;
                    Countdown.Text = Convert.ToString(i);
                    Thread.Sleep(1000);
                   
                }
                Redlight.BackColor = Color.Gray;
            }
        }
    }
}
