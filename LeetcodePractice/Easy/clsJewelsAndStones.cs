﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice.Easy
{
    /*771. Jewels and Stones
     * You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
        Letters are case sensitive, so "a" is considered a different type of stone from "A".

        Example 1:
        Input: jewels = "aA", stones = "aAAbbbb"
        Output: 3
        
        Example 2:
        Input: jewels = "z", stones = "ZZ"
        Output: 0

        Constraints:
        1 <= jewels.length, stones.length <= 50
        jewels and stones consist of only English letters.
        All the characters of jewels are unique.
    */
    class clsJewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < jewels.Length; i++)
                hs.Add(jewels[i]);
            int result = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (hs.Contains(stones[i]))
                    result++;
            }
            return result;
        }
    }
}
