using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_LongestValidParentheses
{
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            int left = 0, right = 0, maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    left++;
                }
                else
                {
                    right++;
                }

                if (left == right)
                {
                    maxLength = Math.Max(maxLength, 2 * right);
                }
                else if (right > left)
                {
                    left = right = 0;
                }
            }

            left = right = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ')')
                {
                    right++;
                }
                else
                {
                    left++;
                }

                if (left == right)
                {
                    maxLength = Math.Max(maxLength, 2 * left);
                }
                else if (left > right)
                {
                    left = right = 0;
                }
            }

            return maxLength;
        }
    }

}
