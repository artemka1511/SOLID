using Solid.AccountTypes;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicAccount = new Account() { Type = "Обычный", Balance = 10000 };

            var salaryAccount = new Account() { Type = "Зарплатный", Balance = 10000 };

            Calculator.CalculateInterest(basicAccount, new BaseAccountInterest());

            Calculator.CalculateInterest(salaryAccount, new SalaryAccountInterest());

            Console.WriteLine(basicAccount.Interest);

            Console.WriteLine(salaryAccount.Interest);
        }
    }
}
