using System;

namespace AlgorithmsCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("GetArrayLength");
        int[] nums = {1, 2, 3};
        int res = GetArrayLength(nums);
        Console.WriteLine("Result: " + res);
    }

    static int GetArrayLength(int[] nums)
    {
      return nums.Length;
    }
  }
}
