using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x <= int.MinValue || x >= int.MaxValue)
            {
                return 0;
            }
            int temp = Math.Abs(x);
            int result = 0;
            while (temp > 0)
            {
                // check out of last degit positive scope 2147483647
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && temp % 10 > 7))
                {
                    return 0;
                }

                // Check out of last degit of negative scope -2147483648
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && temp % 10 < -8))
                {
                    return 0;
                }
                result = result * 10 + temp % 10;
                temp /= 10;
            }

            if (x > 0) return result;
            return result * -1;
        }
    }
}
