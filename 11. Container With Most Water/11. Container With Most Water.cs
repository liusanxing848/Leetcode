public class Solution
{
    // Method to find the maximum area of water that can be contained
    public int MaxArea(int[] height)
    {
        // Initialize the variable to store the maximum area found
        int res = 0;

        // Initialize the variable to store the area calculated in each iteration
        int area = 0;

        // Initialize two pointers: one at the beginning and one at the end of the height array
        int left = 0;
        int right = height.Length - 1;

        // Loop until the two pointers meet
        while (left < right)
        {
            // Calculate the area with the current left and right pointers
            area = (Math.Min(height[left], height[right])) * (right - left);

            // Update the maximum area found so far
            res = Math.Max(area, res);

            // Move the pointer that points to the shorter line inward
            // This is because the area is limited by the shorter line,
            // and moving it inward might increase the area
            if (height[left] < height[right])
            {
                left++; // Move the left pointer to the right
            }
            else
            {
                right--; // Move the right pointer to the left
            }
        }

        // Return the maximum area found
        return res;
    }
}
