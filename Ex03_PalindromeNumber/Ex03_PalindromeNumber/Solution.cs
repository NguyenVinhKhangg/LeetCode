using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int number)
        {
            int result, temp;
            result = 0;
            temp = number;

            while (temp > 0)
            {
                result = result * 10 + temp % 10;
                temp = temp / 10;
            }

            return result == number;

        }
    }
}
