using System;
namespace _4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = Convert.ToInt32(Console.ReadLine());
            string[] temp = new string[3];
            Teacher[] teachers = new Teacher[total];
            Student[] students = new Student[total];
            int j = 0;
            int k = 0;
            for (int i = 0; i < total; i++)
            {
                temp = Console.ReadLine().Split();
                if (temp[1] == "老师")
                {
                    teachers[j] = new Teacher(temp[0], temp[1], Convert.ToInt32(temp[2]));                    
                    j++;
                }
                else
                {
                    students[k] = new Student(temp[0], temp[1], Convert.ToInt32(temp[2]));                    
                    k++;
                }
            }
            for(int i=0; i<j; i++)
            {
                IsGood(teachers[k]);
            }
            for(int i=0;i<k;i++)
            {
                IsGood(students[k]);
            }
        }

        static void IsGood(People p)
        {
            if (p.isgood() == 1)
            {
                Console.WriteLine(p.Name + " " + p.Job);
            }
        }
    }
    public abstract class People
    {
        private string name;
        private string job;
        public People(string n,string j)
        {
            name = n;
            job = j;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Job
        {
            set { job = value; }
            get { return job; }
        }
        public virtual int isgood()
        {
            return 0;
        }
    }
    public class Teacher:People
    {
        int papers;
        public Teacher(string n, string j, int papers):base(n,j)
        {
            this.papers = papers;
        }
        public override int isgood()
        {
            if(papers>=4)
                return 1;
            else
                return 0;
        }
    }
    public class Student:People
    {
        int grade;
        public Student(string n, string j, int grade):base(n,j)
        {
            this.grade = grade;
        }
        public override int isgood()
        {
            if (grade > 90)
                return 1;
            else
                return 0;
        }
    }
}

//for (int i = 0; i < total; i++)
//{
//    temp = Console.ReadLine().Split();
//    if (temp[1] == "老师")
//    {
//        teachers[j] = new Teacher(temp[0], temp[1], Convert.ToInt32(temp[2]));
//        IsGood(teachers[j]);
//        j++;
//    }
//    else
//    {
//        students[k] = new Student(temp[0], temp[1], Convert.ToInt32(temp[2]));
//        IsGood(students[k]);
//        k++;
//    }
//}
//不能这样一边读入一遍输出，会乱的，作业平台会判错!! 
//作业平台的输出顺序貌似也有玄机