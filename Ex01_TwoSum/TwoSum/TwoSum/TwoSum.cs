using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSum 
    {
        public int[] CaculateTwoSum(int[] nums, int target)
        {
            int[] arr = new int[2];
            HashSet<int> compareSet = new HashSet<int>();

            int i;
            for (i = 0; i < nums.Length; i++)
            {
                if (compareSet.Contains(target - nums[i]))
                {
                    break;
                }
                compareSet.Add(nums[i]);
            }

            for (int j = 0; j < i; j++)
            {
                if (target - nums[i] == nums[j])
                {
                    arr[0] = i;
                    arr[1] = j;
                }

            }
            return arr;
        }
    }
}
