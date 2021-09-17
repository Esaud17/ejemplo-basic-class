using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Library
{
    public class Utils
    {
        public static bool IsPar(int number)
        {
            bool result = number % 2 == 0;
            return result;
        }

        public static bool IsPrime(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
