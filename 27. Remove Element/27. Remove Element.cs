public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        if(nums == null || nums.Length == 0)
        {
            return 0; //corner case
        }
        
        int slowIndex = 0;
        int fastIndex = 0;
        
        while(slowIndex < nums.Length  && fastIndex < nums.Length )
        {
            if(nums[fastIndex] != val) //if not val, slow and fast both move forward
            {
                nums[slowIndex] = nums[fastIndex];
                slowIndex++;
                fastIndex++;
            }
            else //if val found, fastindex move forward , slow index not moving, fast indext moving simulate delete that element
            {
                fastIndex++;
            }
            
        }
        return slowIndex;
    }
}