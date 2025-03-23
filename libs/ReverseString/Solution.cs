namespace ReverseString;

public class Solution
{
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
