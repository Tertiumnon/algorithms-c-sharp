using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            Stack<int> singleNums = new Stack<int>();
            Array.Sort(nums);
            int? prev = null;
            foreach (int n in nums)
            {
                if (prev != n)
                {
                    singleNums.Push(n);
                }
                else
                {
                    singleNums.Pop();
                }
                prev = n;
            }
            return singleNums.Pop();
        }
    }
}
