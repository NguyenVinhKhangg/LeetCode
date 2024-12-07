using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_StringToInteger_Atoi_
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            int sign = 1, result = 0;
            bool started = false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == ' ' && !started) continue;

                if ((c == '-' || c == '+') && !started)
                {
                    sign = (c == '-') ? -1 : 1;
                    started = true;
                    continue;
                }

                if (c >= '0' && c <= '9')
                {
                    started = true;

                    if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && (c - '0') > 7))
                    {
                        return sign == -1 ? int.MinValue : int.MaxValue;
                    }

                    result = result * 10 + (c - '0');
                }

                else if (started)
                {
                    break;
                }else
                {
                    return 0;
                }
            }

            return result * sign;
        }
    }
}
