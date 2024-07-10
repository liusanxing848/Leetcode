public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
{
    // Dictionary to count the frequency of each number in the array
    Dictionary<int, int> count = new Dictionary<int, int>();
    
    // Array of lists to group numbers by their frequency
    // The size of the array is nums.Length + 1 to account for frequencies from 0 to nums.Length
    List<int>[] freq = new List<int>[nums.Length + 1];

    // Initialize each list in the freq array
    for(int i = 0; i < freq.Length; i++)
    {
        freq[i] = new List<int>();
    }

    // Count the frequency of each number in the nums array
    foreach(int n in nums)
    {
        if(count.ContainsKey(n))
        {
            count[n]++;
        }
        else
        {
            count[n] = 1; //can also be like count.Add(n, 1)
        }
    }
    
    // Group numbers by their frequency in the freq array
    foreach (var entry in count)
    {
        // entry.Key is the number, entry.Value is its frequency
        freq[entry.Value].Add(entry.Key);
    }

    // Result array to store the top k frequent elements
    int[] res = new int[k];
    int index = 0;

    // Iterate from the highest possible frequency to the lowest
    for(int i = freq.Length - 1; i > 0 && index < k; i--)
    {
        // Add elements with the current frequency to the result array
        foreach(int n in freq[i])
        {
            res[index++] = n;
            // If we have added k elements, return the result
            if(index == k)
            {
                return res;
            }
        }
    }
    
    // Return the result array (this line is reached only if k is not met in the loop)
    return res;
}

}