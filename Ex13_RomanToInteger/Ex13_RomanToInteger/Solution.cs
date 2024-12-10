using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            // Dictionary<char,int> transList = new Dictionary<char,int>();
            // transList.Add('I',1);
            // transList.Add('V',5);
            // transList.Add('X',10);
            // transList.Add('L',50);
            // transList.Add('C',100);
            // transList.Add('D',500);
            // transList.Add('M',1000);        

            int result = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (transList(s[i]) >= transList(s[i + 1]))
                {
                    result += transList(s[i]);
                }
                else
                {
                    result -= transList(s[i]);
                }
            }
            return result + transList(s[s.Length - 1]);
        }

        private int transList(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };
            return 0;
        }
    }
}
