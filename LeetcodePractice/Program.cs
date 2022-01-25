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
            List<bool> lstResult = new List<bool>();
            clsShuffleTheArray obj = new clsShuffleTheArray();
            obj.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 },3);
        }
    }
}
