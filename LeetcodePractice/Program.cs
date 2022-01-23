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
            clsRemoveDuplicatesFromSortedArray obj = new clsRemoveDuplicatesFromSortedArray();
            obj.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4});
        }
    }
}
