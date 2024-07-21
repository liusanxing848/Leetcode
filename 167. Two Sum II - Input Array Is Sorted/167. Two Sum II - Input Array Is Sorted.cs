public class Solution 
{
    // Method to find two numbers that add up to a specific target
    // Assumes that the input array 'numbers' is sorted in ascending order
    public int[] TwoSum(int[] numbers, int target) 
    {
        // Initialize two pointers: 'l' starting from the beginning and 'r' from the end of the array
        int l = 0, r = numbers.Length - 1;

        // Loop until the two pointers meet
        while (l < r) 
        {
            // Calculate the sum of the elements at the two pointers
            int curSum = numbers[l] + numbers[r];

            // If the current sum is greater than the target, move the right pointer to the left
            if (curSum > target) {
                r--;
            } 
            // If the current sum is less than the target, move the left pointer to the right
            else if (curSum < target) {
                l++;
            } 
            // If the current sum equals the target, return the 1-based indices of the two numbers
            else {
                return new int[]{l + 1, r + 1};
            }
        }
        
        // If no such pair is found, return an empty array
        return new int[0];
    }
}
