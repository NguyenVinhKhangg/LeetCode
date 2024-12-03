using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_FindTheIndexOfTheFirstOccurrenceInString
{
    internal class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    for (int j = i; j < i + needle.Length; j++)
                    {
                        if (haystack[j] != needle[j - i])
                        {
                            break;
                        }
                        if (j == i + needle.Length - 1)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
