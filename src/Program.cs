using System;


namespace Algorithms
{
  class Program
  {
    static void Main()
    {
      //var watch = System.Diagnostics.Stopwatch.StartNew();
      //watch.Start();

      //Tree<INode> arg1 = new Tree<INode>;
      //int res = DeleteNode(arg1);

      //Console.WriteLine("Elapsed={0}", watch.Elapsed);
      // Console.WriteLine("Result: " + res);
      // Console.WriteLine("Result: " + String.Join(",", res));
    }

    static int ReverseInteger(int x)
    {
      if (!Int32.TryParse(x.ToString(), out _))
      {
        return 0;
      }
      bool isPositive = true;
      if (x < 0)
      {
        isPositive = false;
        x *= -1;
      }
      char[] arr = x.ToString().ToCharArray();
      int length = arr.Length;
      int length2 = length / 2;
      int i = 0;
      while (i < length2)
      {
        char a = arr[i];
        arr[i] = arr[length - i - 1];
        arr[length - i - 1] = a;
        i++;
      }
      string res = String.Join("", arr);
      if (!Int32.TryParse(res.ToString(), out _))
      {
        return 0;
      }
      return isPositive ? int.Parse(res) : int.Parse(res) * -1;
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
        if (r == "")
        {
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
