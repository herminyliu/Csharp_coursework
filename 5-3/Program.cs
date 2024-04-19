using System;
namespace _5_3
{//“本月”指的是十一月哦！
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employee1 = new string[4];
            employee1 = Console.ReadLine().Split();
            string[] employee2 = new string[5];
            employee2 = Console.ReadLine().Split();
            SalariedEmployee E1 = new SalariedEmployee(employee1[0], employee1[1], Convert.ToDateTime(employee1[2]), Convert.ToInt32(employee1[3]));
            Console.WriteLine(E1.Earning());
            HourlyEmplyee E2 = new HourlyEmplyee(employee2[0], employee2[1], Convert.ToDateTime(employee2[2]), Convert.ToDecimal(employee2[3]), Convert.ToInt32(employee2[4]));
            Console.WriteLine(E2.Earning());
        }
    }
    abstract public class Employee
    {
        public Employee(string name, string id, DateTime date)
        {
            Name = name;
            Id = id;
            Date = date;
        }

        public string Name { get; set; }    
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public abstract decimal Earning();
    }
    public class SalariedEmployee:Employee
    {
        public SalariedEmployee(string name, string id, DateTime date,decimal monthlySalary) : base(name,id,date)
        {
            MonthlySalary = monthlySalary;
        }

        public decimal MonthlySalary { get; set; }
        public override decimal Earning()
        {
            if(Date.Month == 11)
            {
                return MonthlySalary + 300M;
            }
            else
            {
                return MonthlySalary;
            }
                
        }
    }
    public class HourlyEmplyee:Employee
    {
        public HourlyEmplyee(string name, string id, DateTime date, decimal dailySalary, int workingDays) : base(name, id, date)
        {
            DailySalary = dailySalary;
            WorkingDays = workingDays;
        }

        public decimal DailySalary { get; set; }
        public int WorkingDays { get; set; }
        public override decimal Earning()
        {
            decimal salary = 0M;
            if(WorkingDays <= 22)
            {
                salary += WorkingDays* DailySalary;                
            }
            else
            {
                salary += 22 * DailySalary + (WorkingDays - 22) * DailySalary * 1.5M;
            }
            if(Date.Month == 11)
            {
                salary += 300M;
            }
            return salary;
        }
    }
}