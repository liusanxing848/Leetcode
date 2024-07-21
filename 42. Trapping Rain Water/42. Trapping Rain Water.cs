public class Solution 
{
    // Method to calculate the total amount of trapped rainwater
    public int Trap(int[] height) 
    {
        // Check if the input array is null or empty
        if (height == null || height.Length == 0)
        {
            return 0; // Return 0 as no water can be trapped
        }

        // Initialize two pointers: one at the beginning and one at the end of the height array
        int left = 0;
        int right = height.Length - 1;

        // Initialize variables to store the maximum height encountered from the left and right
        int leftMax = height[left];
        int rightMax = height[right];

        // Initialize the variable to store the total trapped water
        int res = 0;

        // Loop until the two pointers meet
        while (left < right)
        {
            // If the maximum height on the left is less than the maximum height on the right
            if (leftMax < rightMax)
            {
                left++; // Move the left pointer to the right
                // Update the maximum height encountered from the left
                leftMax = Math.Max(leftMax, height[left]);
                // Calculate the trapped water at the current left position and add it to the total
                res += leftMax - height[left];
            }
            else
            {
                right--; // Move the right pointer to the left
                // Update the maximum height encountered from the right
                rightMax = Math.Max(rightMax, height[right]);
                // Calculate the trapped water at the current right position and add it to the total
                res += rightMax - height[right];
            }
        }

        // Return the total amount of trapped water
        return res;
    }
}
