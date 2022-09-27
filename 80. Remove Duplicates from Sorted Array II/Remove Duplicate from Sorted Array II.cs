public class Solution
{
    public int RemoveDuplicates(int[] nums) 
    {
        int j = 2;
        for(int i = 2; i < nums.Length; i++)
        {
            if(nums[i] > nums[j-2])
            {
                nums[j] = nums[i];
                j++;
            }
        }
        
        return j;
    }
}

//十分巧妙的模板。要两个duplicate则位数字2，若要n个duplicate，把所有的2 替换成n
