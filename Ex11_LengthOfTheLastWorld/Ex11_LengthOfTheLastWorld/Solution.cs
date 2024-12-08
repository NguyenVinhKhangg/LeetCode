using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_LengthOfTheLastWorld
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {

                if (s[i] == ' ')
                {
                    break;
                }
                count++;
            }
            return count;
        }
    }
}
