using System;
using System.Collections.Generic;

namespace Algorithms
{
  public class SingleNumberSolution
  {
    public int SingleNumber(int[] nums)
    {
      Array.Sort(nums);
      int length = nums.Length - 1;
      if (length > 1)
      {
        if (nums[0] != nums[1])
        {
          return nums[0];
        }
        else if (nums[length] != nums[length - 1])
        {
          return nums[length];
        }
        for (int i = 1; i < length; i++)
        {
          int current = nums[i];
          if (nums[i - 1] != current && nums[i + 1] != current)
          {
            return current;
          }
        }
      }
      return nums[0];
    }
  }
}
