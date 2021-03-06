using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice.Easy
{
    /*1365. How Many Numbers Are Smaller Than the Current Number
     * Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
    Return the answer in an array.

    Example 1:
    Input: nums = [8,1,2,2,3]
    Output: [4,0,1,1,3]
    Explanation: 
    For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
    For nums[1]=1 does not exist any smaller number than it.
    For nums[2]=2 there exist one smaller number than it (1). 
    For nums[3]=2 there exist one smaller number than it (1). 
    For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).

    Example 2:
    Input: nums = [6,5,4,8]
    Output: [2,1,0,3]

    Example 3:
    Input: nums = [7,7,7,7]
    Output: [0,0,0,0]

    Constraints:
    2 <= nums.length <= 500
    0 <= nums[i] <= 100
    */
    class clsHowManyNumbersAreSmallerThanTheCurrentNumber
    {
        //REF: https://www.youtube.com/watch?v=eHqwoWiMDfY
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] freq = new int[101];//101 from constraint
            for (int i = 0; i < nums.Length; i++)//count the frequencies of each element in input array
            {
                freq[nums[i]]++;
            }
            //Add cummulative count
            for (int i = 1; i < 101; i++)
            {
                freq[i] += freq[i - 1];
            }
            //Get frequency of 1 index eearlier one
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    nums[i] = 0;
                else
                    nums[i] = freq[nums[i] - 1];
            }
            return nums;
        }
    }
}
