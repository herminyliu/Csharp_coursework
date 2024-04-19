using System;

namespace _5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pet1 = new string[2];
            pet1 = Console.ReadLine().Split();
            string[] pet2 = new string[2];
            pet2 = Console.ReadLine().Split();
            Cat miao = new Cat(pet1[0], Convert.ToInt32(pet1[1]));
            Dog wang = new Dog(pet2[0], Convert.ToInt32(pet2[1]));
            Fun(miao);
            
            Fun(wang);
        }
        static void Fun(Pet p)
        {
            p.Speak();
            p.Eat();
            Console.WriteLine("{0}{1}斤", p.Name, p.Weight);
        }
    }
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Pet(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void Speak();
        public abstract void Eat();

    }
    public class Cat:Pet
    {
        public Cat(string name, int weight) : base(name, weight) { }
        public override void Speak()
        {
            Console.WriteLine("MIAOMIAO");
        }
        public override void Eat()
        {
           Weight = Weight + 1;
        }
    }
    public class Dog : Pet
    {
        public Dog(string name, int weight) : base(name, weight) { }
        public override void Speak()
        {
            Console.WriteLine("WANGWANG");
        }
        public override void Eat()
        {
            Weight = Weight + 2;
        }
    }
}