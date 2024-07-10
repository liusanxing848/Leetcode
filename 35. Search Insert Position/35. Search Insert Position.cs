public class Solution
 {

    //Binary Search
    public int SearchInsert(int[] nums, int target) 
    {
        int left = 0; 
        int right = nums.Length - 1;
        int mid;

        while (left <= right)
        {
            mid = (left + right) / 2;

            if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else if(nums[mid] > target)
            {
                right = mid - 1;
            }
            else //(when nums[mid] == target), when found.
            {
                return mid;
            }
        }
        return left;
    }
}