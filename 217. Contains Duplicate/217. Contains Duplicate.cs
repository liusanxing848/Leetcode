public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        return nums.Length != nums.Distinct().Count();
    }
}