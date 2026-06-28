using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Provides integer operations </summary>
    public class Operations
    {
        /// <summary> Returns the maximum integer from a list, or 0 if the list is null or empty </summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int max = nums[0];

            foreach (int num in nums)
            {
                if (num > max)
                    max = num;
            }

            return max;
        }
    }
}
