using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.AccountTypes
{
    public interface ICalculateInterest
    {
        void CalculateInterest(Account account);
    }
}
