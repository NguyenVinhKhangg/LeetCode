using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_MedianOfTwoSortedArray
{
    internal class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> arr = new List<int>();
            int i = 0, j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    arr.Add(nums1[i++]);
                }
                else
                {
                    arr.Add(nums2[j++]);
                }
            }

            //add remaining value of nums1
            while (i < nums1.Length)
            {
                arr.Add(nums1[i++]);
            }
            //add remaining value of nums2
            while (j < nums2.Length)
            {
                arr.Add(nums2[j++]);
            }

            int n = arr.Count;
            // If length of array is even
            if (n % 2 == 0)
            {
                int mid1 = n / 2;
                int mid2 = mid1 - 1;
                return (arr[mid1] + arr[mid2]) / 2.0;
            }
            // If length of array is odd
            else
            {
                return arr[n / 2];
            }

        }
    }
}
