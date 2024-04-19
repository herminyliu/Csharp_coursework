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
            int max = Convert.ToInt32(num[0]);
            for (int i = 1; i < num.Length; i++)
            {
                if (Convert.ToInt32(num[i]) > max)
                {
                    max = Convert.ToInt32(num[i]);
                }
                else
                    continue;
            }
            Console.WriteLine(max);

        }
    }
}