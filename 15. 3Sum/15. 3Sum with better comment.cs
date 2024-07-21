public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        // Sort the array to make it easier to find and eliminate duplicates
        Array.Sort(nums);

        // Use HashSet to store the unique triplets that sum up to zero
        HashSet<List<int>> uniqueTriplets = new HashSet<List<int>>();

        // Iterate through the array, fixing one element at a time
        for (int fixedIndex = 0; fixedIndex < nums.Length - 2; fixedIndex++) 
        {
            // Skip duplicates for the fixed element
            if (fixedIndex == 0 || nums[fixedIndex] != nums[fixedIndex - 1]) 
            {
                int leftPointer = fixedIndex + 1;
                int rightPointer = nums.Length - 1;

                // Use two pointers to find the other two elements that sum up to zero with the fixed element
                while (leftPointer < rightPointer) 
                {
                    int currentSum = nums[fixedIndex] + nums[leftPointer] + nums[rightPointer];

                    if (currentSum == 0) 
                    {
                        // If the sum is zero, add the triplet to the result set
                        uniqueTriplets.Add(new List<int> { nums[fixedIndex], nums[leftPointer], nums[rightPointer] });

                        // Move the pointers to the next distinct elements
                        leftPointer++;
                        rightPointer--;

                        // Skip duplicates for the left pointer
                        while (leftPointer < rightPointer && nums[leftPointer] == nums[leftPointer - 1]) 
                        {
                            leftPointer++;
                        }

                        // Skip duplicates for the right pointer
                        while (leftPointer < rightPointer && nums[rightPointer] == nums[rightPointer + 1]) 
                        {
                            rightPointer--;
                        }
                    } 
                    else if (currentSum < 0) 
                    {
                        // If the sum is less than zero, move the left pointer to the right
                        leftPointer++;
                    } 
                    else 
                    {
                        // If the sum is greater than zero, move the right pointer to the left
                        rightPointer--;
                    }
                }
            }
        }

        // Convert the HashSet to a list and return it
        return uniqueTriplets.ToList<IList<int>>();
    }
}
