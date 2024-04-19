using System;

namespace _3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();
            SavingsAccount saver1 = new SavingsAccount(Convert.ToInt32(data[0]));   
            SavingsAccount saver2 = new SavingsAccount(Convert.ToInt32(data[1]));
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            saver1.Show();
            saver2.Show();
            SavingsAccount.ModifyInterestRate(0.05);
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            saver1.Show();
            saver2.Show();
        }
    }
    class SavingsAccount
    {
        static double annualInterestRate = 0.04;
        
        public static void ModifyInterestRate(double newAnnualInterestRate)
        {
            annualInterestRate = newAnnualInterestRate;
        }
        double savingBalance;
        public SavingsAccount(double saving)
        {
            SavingBalance = saving;
        }
        public double SavingBalance
        {
            get { return savingBalance; }
            set { savingBalance = value; }
        }
        public void CalculateMonthlyInterest()
        {
            double MonthlyInterest;
            MonthlyInterest = savingBalance * annualInterestRate / 12;
            savingBalance = MonthlyInterest + savingBalance;
        }
        public void Show()
        {
            Console.WriteLine("SavingBalance:{0:F2}",savingBalance);
        }
        
    }
}