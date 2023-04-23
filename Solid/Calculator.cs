using Solid.AccountTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public static class Calculator
    {
        public static void CalculateInterest(Account account, ICalculateInterest calcObject)
        {
            calcObject.CalculateInterest(account);
        }
    }
}
