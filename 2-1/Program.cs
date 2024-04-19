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
            string[] str = input.Split(',');
            int year = Convert.ToInt32(str[0]);
            int month = Convert.ToInt32(str[1]);
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(31);break;
                case 2:
                    if(year%4==0)
                    {
                        if (year % 100 != 0)
                            Console.WriteLine(29);
                        else
                        {
                            if (year % 400 == 0)
                                Console.WriteLine(29);
                            else
                                Console.WriteLine(28);
                        }
                    }
                    else
                    {
                        Console.WriteLine(28);
                    }
                    break;
                default:
                    Console.WriteLine(30);break;
            }


        }
    }
}