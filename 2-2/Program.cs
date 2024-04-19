using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//求a+aa+aaa+aaaa+...+aa...a(第n项，n个a)，其中a是1～9的整数。例如，a=1,n=3时，式子为1+11+111；当a=5,n=5时，式子为5+55+555+5555+55555。

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] str = input.Split(' ');
            int a = Convert.ToInt32(str[0]);
            int n = Convert.ToInt32(str[1]);
            int sum = 0;
            int add = a;
            for(int i=0;i<n;i++)
            {
                sum += add;
                
                add = add * 10 + a;
            }
            Console.WriteLine(sum);
        }
    }
}