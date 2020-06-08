using System;


namespace AlgorithmsCSharp
{
  class Program
  {
    static void Main()
    {
      var watch = System.Diagnostics.Stopwatch.StartNew();
      watch.Start();

      int arg1 = 15;
      string[] res = FizzBuzz(arg1);

      Console.WriteLine("Elapsed={0}", watch.Elapsed);
      Console.WriteLine("Result: " + String.Join(",", res));
    }

    static string[] FizzBuzz(int n)
    {
      string[] res = new string[n];
      for (int i = 0; i < n; i++)
      {
        int s = i + 1;
        string r = "";
        if (s % 3 == 0)
        {
          r += "Fizz";
        }
        if (s % 5 == 0)
        {
          r += "Buzz";
        }
        if (r == "") {
          r += s.ToString();
        }
        res[i] = r;
      }
      return res;
    }

    static int RemoveDuplicates(int[] nums)
    {
      int len = nums.Length;
      if (len > 1)
      {
        int i = 0;
        int j = 1;
        int prev = nums[i];
        while (i < len)
        {
          if (nums[i] != prev)
          {
            nums[j] = nums[i];
            prev = nums[i];
            j++;
          }
          i++;
        }
        return j;
      }
      return len;
    }

    static void ReverseString(char[] s)
    {
      int len = s.Length - 1;
      int i = 0;
      while (i < len)
      {
        char a = s[i];
        s[i] = s[len];
        s[len] = a;
        i++;
        len--;
      }
    }
  }
}
