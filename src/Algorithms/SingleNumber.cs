using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
  public class SingleNumberSolution
  {
    public int SingleNumber(int[] nums)
    {
      Dictionary<int, bool> singleNums = new Dictionary<int, bool>();
      foreach (int n in nums)
      {
        if (singleNums.ContainsKey(n))
        {
          singleNums.Remove(n);
        }
        else
        {
          singleNums.Add(n, true);
        }
      }
      return singleNums.First().Key;
    }
  }
}
