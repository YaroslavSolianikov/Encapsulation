using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_003
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(new DateTime(2021, 01, 20));
            bankAccount.Percent = 20;
            bankAccount.Sum = 50000;
            bankAccount.DaysInfo();
            bankAccount.SumInfo();
            Console.ReadKey();
        }
    }
}
