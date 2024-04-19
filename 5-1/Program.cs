using System.Net;
using System.Xml.Linq;

namespace _5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] threedayinfo = new string[4];
            threedayinfo = Console.ReadLine().Split();
            ThreeDayPackage threeday = new ThreeDayPackage(threedayinfo[0], threedayinfo[1], Convert.ToInt32(threedayinfo[2]), Convert.ToDouble(threedayinfo[3]));
            string[] overnightinfo = new string[5];
            overnightinfo = Console.ReadLine().Split();
            OvernightPackage overnight = new OvernightPackage(overnightinfo[0], overnightinfo[1], Convert.ToInt32(overnightinfo[2]), Convert.ToDouble(overnightinfo[3]), Convert.ToDouble(overnightinfo[4]));
            
            Console.WriteLine(threeday.Freight());
            Console.WriteLine(overnight.Freight());
        }
        
    }
    abstract class Package
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Weight { get; set; }
        public double Mile { get; set; }
        public Package(string name, string address, int weight, double mile)
        {
            Name = name;
            Address = address;
            Weight = weight;
            Mile = mile;
        }
        public abstract double Freight();
    }
    class ThreeDayPackage : Package
    {
        public ThreeDayPackage(string name, string address, int weight, double mile) : base(name, address, weight, mile) { } //还是要有这句话的
        public override double Freight()
        {
            return Weight * Mile * 0.01;
        }

    }
    class OvernightPackage : ThreeDayPackage
    {
        public double Fee { get; set; }
        public OvernightPackage(string name, string address, int weight, double mile, double fee) : base(name, address, weight, mile)
        {
            Fee = fee;
        }
        public override double Freight()
        {
            return Weight * Mile * 0.01 + Weight * Fee * 0.01;
        }
    }
}