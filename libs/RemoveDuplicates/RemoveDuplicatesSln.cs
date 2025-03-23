namespace RemoveDuplicates;

public class RemoveDuplicatesSln
{
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
}
