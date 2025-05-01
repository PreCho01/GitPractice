using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class FactorialHelper
    {
        public static int CalculateFact(int n)
        {
            if(n <= 1){
                return 1;
            }
            return n* CalculateFact(n-1);
        }
    }
}
