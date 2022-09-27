class Solution {
    public int removeDuplicates(int[] nums) {
        if (nums.length == 0)
        {
            return 0;
        }
        
        int i = 0; //i -> counter
        
        for (int j = 1; j < nums.length; j++ )
        {
            if(nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
            
        }
        return 1 + i;
    }
}