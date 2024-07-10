public class Solution 
{
    // Method to find the length of the longest consecutive elements sequence
    public int LongestConsecutive(int[] nums) 
    {
        // Initialize a HashSet to store unique elements from the input array
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0; // Variable to keep track of the longest consecutive sequence

        // Iterate through each number in the HashSet
        foreach (int n in numSet) 
        {
            // Check if 'n' is the start of a new sequence (i.e., 'n-1' is not in the set)
            if (!numSet.Contains(n - 1)) 
            {
                int length = 1; // Initialize the length of the current sequence
                
                // Check for the next consecutive numbers in the sequence
                while (numSet.Contains(n + length)) 
                {
                    length++; // Increment the length for each consecutive number found
                }
                
                // Update the longest sequence length if the current sequence is longer
                longest = Math.Max(length, longest);
            }
        }
        // Return the length of the longest consecutive sequence found
        return longest;
    }
}
