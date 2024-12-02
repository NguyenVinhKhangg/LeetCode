using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[result] = nums[i];
                    result++;
                }
            }

            return result;
        }
    }
}
