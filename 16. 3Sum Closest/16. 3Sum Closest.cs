public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        int closestSum = nums[0] + nums[1] + nums[2]; //initialize 

        Array.Sort(nums); //use 2 pointer method, initialize array.
        for(int i = 0; i < nums.Length - 2; i ++)
        {
            int leftPointer = i + 1;
            int rightPointer = nums.Length - 1;
            
            while (leftPointer < rightPointer)
            {
                int sum = nums[i] + nums[leftPointer] + nums[rightPointer];
                if(sum == target)
                {
                    return sum;
                }
                else if(Math.Abs(sum - target) < Math.Abs(closestSum - target)) //the closest sum
                {
                    closestSum = sum;
                }

                if(sum < target) //need add bigger element
                {
                    leftPointer ++;
                }
                if(sum > target) //added element too large.
                {
                    rightPointer --;
                }
            }
        }
        return closestSum;   
    }
}