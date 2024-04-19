using System;
namespace _3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();
            double result = 0;
            
            if (data[0] == "ok" || data[0]=="good")
            {
                result = Program.AvgGrade(data);        
            }
            else
            {
                int[] numdata = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    numdata[i] = Convert.ToInt32(data[i]);
                }
                result = Program.AvgGrade(numdata);
            }
            Console.WriteLine("{0:F1}", result);
        }
        public static double AvgGrade(int[] gra)
        {
            int sum = 0;
            for(int i=0; i < gra.Length; i++)
            {
                sum+=gra[i];
            }
            return sum / gra.Length;
        }
        public static double AvgGrade(string[] sgra)
        {
            double sum = 0;
            for (int i = 0; i < sgra.Length; i++)
            {
                if (String.Compare(sgra[i],"good") == 0)
                {
                    sum += 4;
                }
                else
                {
                    sum += 1;
                }
            }
            return sum / sgra.Length;
        }
    }
}