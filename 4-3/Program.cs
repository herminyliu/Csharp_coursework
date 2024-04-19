using System;
namespace _4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Car car1 = new Car(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]), Convert.ToInt32(input[2]));
            car1.Show2();
        }
    }
    public class Vehicle
    {
        protected int wheel;
        protected int weight;
        public int Wheel
        {
            get { return wheel; }   
            set 
            {
                if (value > 0)
                    wheel = value;
                else
                    wheel = 0;
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    weight = 0;
            }
        }
        public Vehicle(int wheel,int weight)
        {
            Wheel = wheel;
            Weight = weight;
        }
        public void Show()
        {
            Console.WriteLine("Car is running");
            Console.Write("wheels:{0};weight:{1};",Wheel,Weight);
        }
    }
    public class Car:Vehicle
    {
        private int passenger_load;
        public Car(int wheel, int weight,int passenger_load):base(wheel,weight)
        {
            this.passenger_load = passenger_load;
        }
        public void Show2()
        {
            Show();
            Console.Write("passenger:{0}", passenger_load);
        }
    }
}
