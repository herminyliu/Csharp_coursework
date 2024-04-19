/*运动时，可以利用心率监测仪来查看心率是否处于安全范围内。
 * 其中最高心率=220-年龄；目标心率是最高心率的50%-85%（取整）。

（1）创建一个名称为HeartRates的类。

字段：人的名字（string）、出生年份(年)。

属性：一个返回年龄（以年计算）的属性（int,只读，即属性中只有get访问器）。

方法：一个计算并返回最高心率的方法；一个计算并返回最低目标心率的方法；
一个计算并返回最高目标心率的方法。

（2）在主方法中，实例化HeartRates类，从控制台中输入个人信息姓名，出生年份。
最后输出对象的信息，包括姓名；年龄；最高心率，最低目标心率，最高目标心率信息（用空格分隔，具体格式如样例所示）。
*/
namespace _3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();
            HeartRates test = new HeartRates(data[0], Convert.ToInt32(data[1]));
            test.Cal();
            test.Show();
        }
    }
    class HeartRates
    {
        readonly string name;
        readonly int age;
        int highestRate;
        int highestTargetRate;
        int lowestTargetRate;
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public HeartRates(string name, int year)
        {
            this.name = name;  //?
            this.age = 2022 - year;  //?
        }
        public void Cal()
        {
            highestRate = 220 - age;
            lowestTargetRate = Convert.ToInt32(highestRate * 0.5);
            highestTargetRate = Convert.ToInt32(highestRate * 0.85); // 是不是转换过程中取整的问题呢？？
        }
        // out int highestRate,out int lowestTargetRate,out int highestTargetRate
        public void Show()
        {
            //example: 张一 22岁 最高心率198 最低目标心率99 最高目标心率168
            Console.WriteLine("{0} {1}岁 最高心率{2} 最低目标心率{3} 最高目标心率{4}",
                name,age,highestRate,lowestTargetRate,highestTargetRate);
        }
    }
    
}