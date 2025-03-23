namespace ReverseInteger;

public class Solution
{
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
}
