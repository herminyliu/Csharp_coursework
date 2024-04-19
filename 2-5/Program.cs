// See using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] str = input.Split();
            Triangle t1 = new Triangle();
            t1.A1 = Convert.ToDouble(str[0]);
            t1.A2 = Convert.ToDouble(str[1]);
            t1.A3 = Convert.ToDouble(str[2]);
            t1.Print(t1.GetCircumference());
        }
    }
    class Triangle  //不知道可以不可以函数重载
    {
        private double a1, a2, a3;
                      
        public double A1
        {
            get { return a1; }
            set
            {
                if (value <= 0)
                {
                    a1 = 0;
                }
                else
                {
                    a1 = value;
                }
            }
        }
        public double A2
        {
            get { return a2; }
            set
            {
                if (value <= 0)
                {
                    a2 = 0;
                }
                else
                {
                    a2 = value;
                }
            }
        }
        public double A3
        {
            get { return a3; }
            set
            {
                if (value <= 0)
                {
                    a3 = 0;
                }
                else
                {
                    a3 = value;
                }
            }
        }

        public double GetCircumference()
        {
            double circumference;
            if (a1 * a2 * a3 != 0)
            {
                circumference = a1 + a2 + a3;
            }
            else
            {
                circumference = 0;
            }
            return circumference;
        }

        public void Print(double circumference)
        {
            Console.WriteLine(circumference);
        }
    }
}
