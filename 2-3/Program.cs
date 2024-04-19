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
            if (input == null)
            {
                return;
            }
            string[] cnums = input.Split(" ");
            int[] collected;
            int len = 0;
            collected = new int[cnums.Length];
            for (int i = 0; i < cnums.Length; i++)
            {
                if(10 <= Convert.ToInt32(cnums[i]) && Convert.ToInt32(cnums[i]) <= 100)
                {
                    int flag = 0;
                    for(int j = 0; j < len; j++) //查找是否重复
                    {
                        if (Convert.ToInt32(cnums[i]) == collected[j])
                        {
                            flag = 1;
                            break;
                        }                       
                    }
                    if(flag == 1)
                    {
                        continue;
                    }
                    else
                    {
                        collected[len] = Convert.ToInt32(cnums[i]);
                        len++;
                    }
                }
            }
            if(len > 0)
            {
                for (int i = 0; i < len; i++)
                    if(i == 0)
                    {
                        Console.Write(collected[i]);
                    }
                    else
                    {
                        Console.Write(" {0}", collected[i]);
                    }                       
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}