using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] num = input.Split(' ');
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToDouble(num[i]);
            }
            Console.WriteLine(sum/num.Length);
        }
    }
}