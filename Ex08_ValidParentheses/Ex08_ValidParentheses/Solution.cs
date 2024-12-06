using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_ValidParentheses
{
    internal class Solution
    {
        public bool IsValid(string s)
        {
            //I copied this insane solution from a smart guy on leetcode. 
            //    while (s.Contains("[]") || s.Contains("()") || s.Contains("{}")){
            //     s = s.Replace("[]","").Replace("()","").Replace("{}","");
            //    }
            //     return s.Length == 0;

            //Another optimized solution.
            Stack<char> stacks = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    stacks.Push(c);
                }

                else if (c == '}' && (stacks.Count == 0 || stacks.Pop() != '{'))
                {
                    return false;
                }
                else if (c == ']' && (stacks.Count == 0 || stacks.Pop() != '['))
                {
                    return false;
                }
                else if (c == ')' && (stacks.Count == 0 || stacks.Pop() != '('))
                {
                    return false;
                }
            }
            return stacks.Count == 0;
        }
    }
}
