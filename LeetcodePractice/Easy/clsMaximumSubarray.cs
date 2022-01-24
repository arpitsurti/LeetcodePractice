﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice.Easy
{
    /*53. Maximum Subarray
     * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
        A subarray is a contiguous part of an array.
        
        Example 1:
        Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.

        Example 2:
        Input: nums = [1]
        Output: 1
        
        Example 3:
        Input: nums = [5,4,-1,7,8]
        Output: 23
        
        Constraints:
        1 <= nums.length <= 105
        -104 <= nums[i] <= 104
        
        Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
    */
    class clsMaximumSubarray
    {
        //https://leetcode.com/problems/maximum-subarray/discuss/1595186/Java-oror-Kadane-ororDivide-and-Conquer-oror-Dp
        public int MaxSubArray(int[] nums)
        {
            int currSum = nums[0];
            int maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(currSum + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }
            return maxSum;
        }
    }
}
