using System;

namespace _4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] in1 = Console.ReadLine().Split();
            string[] in2 = Console.ReadLine().Split();
            Complete c1 = new Complete(Convert.ToInt32(in1[0]), Convert.ToInt32(in1[1]));
            Complete c2 = new Complete(Convert.ToInt32(in2[0]), Convert.ToInt32(in2[1]));
            Complete add = Complete.Add(c1, c2);
            Complete sub = Complete.Sub(c1, c2);
            add.NewToString();
            sub.NewToString();
            add.Show();
            Console.Write(" ");
            sub.Show();

        }
    }
    class Complete
    {
        private double real;
        private double image;
        public double Real
        {
            get { return real; }
            set { real = value; }
        }
        public double Image
        {
            get { return image; }       
            set { image = value; }
        }
        public Complete()
        {
            real = 0;
            image = 0;
        }
        public Complete(int real, int image)
        {
            Real = real;
            Image = image;
        }
        public static Complete Add(Complete x, Complete y)
        {
            Complete add= new Complete();
            add.real = x.real + y.real;
            add.image = x.image + y.image;
            return add;
        }
        public static Complete Sub(Complete x, Complete y)
        {
            Complete sub = new Complete();
            sub.real=x.real- y.real;
            sub.image= x.image- y.image;
            return sub;
        }
        public string NewToString()
        {
            if (Image > 0)
                return string.Format("{0}+{1}i", Real, Image);
            else
                return string.Format("{0}{1}i", Real, Image);            
        }
        public void Show()
        {
            Console.Write(NewToString());
        }        
    }
}