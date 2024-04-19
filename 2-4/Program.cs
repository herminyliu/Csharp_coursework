using Microsoft.VisualBasic;
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
            string[] str = input.Split(" ");           
            Citizen c1 = new Citizen(str[0], str[1], str[2], str[3]);
            int[] birthdate = c1.Split(str[0]);
            c1.Print(birthdate);
        }
    }
    class Citizen
    {
        private string id;
        private string gender;
        private string name;
        private string famliyAddress;

        public Citizen(string id, string name, string gender, string famliyAddress)
        {
            this.id = id;
            this.gender = gender;
            this.name = name;
            this.famliyAddress = famliyAddress;
        }
        public static int[] Split(string id)
        {
            int[] birthdate;
            birthdate = new int[3];
            string syear = Convert.ToString(id[6]) + Convert.ToString(id[7]) + Convert.ToString(id[8]) + Convert.ToString(id[9]);
            string smonth = Convert.ToString(id[10]) + Convert.ToString(id[11]);
            string sdate = Convert.ToString(id[12]) + Convert.ToString(id[13]);
            birthdate[0] = Convert.ToInt32(syear);
            birthdate[1] = Convert.ToInt32(smonth);
            birthdate[2] = Convert.ToInt32(sdate);
            return birthdate;
        }
        public void Print(int[] birthdate)
        {
            //zhangsan,male,出生于1998年02月24日,居住于xi’an
            Console.WriteLine("{0},{1},出生于{2}年{3:D2}月{4:00}日,居住于{5}", name, gender, birthdate[0], birthdate[1], birthdate[2], famliyAddress);
        }
    }
}