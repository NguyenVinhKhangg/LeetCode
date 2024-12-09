using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int area = (right - left) * Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, area);
                if (height[left] < height[right])
                {
                    left++;
                }
                else if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return maxArea;
        }
    }
}
