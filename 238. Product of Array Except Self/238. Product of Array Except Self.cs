public class Solution 
{
    // Method to calculate the product of all elements except self
    public int[] ProductExceptSelf(int[] nums) 
    {
        // Create an array to store the result
        int[] res = new int[nums.Length];

        // Initialize two variables to keep track of the prefix and postfix products
        int pre = 1; // Prefix product
        int post = 1; // Postfix product

        // First pass: calculate the prefix product for each element
        for (int i = 0; i < nums.Length; i++)
        {
            // Store the current prefix product in the result array
            res[i] = pre;
            // Update the prefix product by multiplying with the current element
            pre *= nums[i];
        }

        // Second pass: calculate the postfix product for each element
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            // Multiply the current element in the result array by the postfix product
            res[i] *= post;
            // Update the postfix product by multiplying with the current element
            post *= nums[i];
        }

        // Return the result array containing the product of all elements except self
        return res;
    }
}
