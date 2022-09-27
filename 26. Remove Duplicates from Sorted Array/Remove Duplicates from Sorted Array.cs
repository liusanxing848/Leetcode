public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        if(nums.Length == 0)
        {
            return 0;
        }
        
        int counter = 0;
        for(int j = 1; j < nums.Length; j++)
        {
            if(nums[counter] != nums[j])
            {
                counter++;
                nums[counter] = nums[j];
            }
        }
        
        return 1 + counter;
    }
}