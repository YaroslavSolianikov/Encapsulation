using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_003
{
    class BankAccount
    {
        private readonly DateTime openingDate;
        private int percent;
        private decimal sum;
        public int Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        public decimal Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        private int SumOfDays()
        {
            TimeSpan span = DateTime.Now - openingDate;
            return span.Days;
        }
        public void DaysInfo() => Console.WriteLine($"Sum of days: {SumOfDays()}");
        private void SumCalc(int years) 
        {
            decimal total = sum + (sum * years * percent / 100);
            Console.WriteLine($"Sum after {years} years: {total}");
        }
        public void SumInfo() => SumCalc(5);
        public BankAccount(DateTime openingDate)
        {
            this.openingDate = openingDate;
        }
    }
}
