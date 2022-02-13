using LeetcodePractice.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            NextGreaterElement(new int[] {1,3,5,2,4},new int[]{6,5,4,3,2,1,7});
        }

         public static int[] NextGreaterElement(int[] nums1, int[] nums2) 
         {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            Stack<int> st = new Stack<int>();
            for(int i=0;i<nums2.Length;i++)
            {
                while(st.Count != 0 && st.Peek() < nums2[i])
                    dict.Add(st.Pop(),nums2[i]);
                st.Push(nums2[i]);
            }
        
            for(int i=0;i<nums1.Length;i++)
            {
                
                nums1[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;
            }
            return nums1;
         }
    }
}
