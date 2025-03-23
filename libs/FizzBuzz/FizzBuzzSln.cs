namespace FizzBuzz;

public class FizzBuzzSln
{
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
}
