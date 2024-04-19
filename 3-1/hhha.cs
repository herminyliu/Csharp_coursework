using System;

namespace _3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();
            Time t1 = new Time();
            Time t2 = new Time(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));
            t1.Show();
            t2.Show();
        }
    }
    public class Time
    {
        private int hour;
        private int minute;
        private int second;
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    hour = 0;
                }
                else
                {
                    hour = value;
                }
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value >= 60)
                {
                    minute = 0;
                }
                else
                {
                    minute = value;
                }
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0 || value >= 60)
                {
                    second = 0;
                }
                else
                {
                    second = value;
                }
            }
        }
        
        public void Show()
        {
            Console.WriteLine("{0:00}时{1:00}分{2:00}秒", hour, minute, second);
        }
        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}