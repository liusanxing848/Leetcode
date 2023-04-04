public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        //using 2 pointers approach, first thing is to sort the array
         Array.Sort(nums); // sort the array to make it easier to eliminate duplicates
         HashSet<List<int>> result = new HashSet<List<int>>(); // use HashSet to eliminate duplicates

    for (int i = 0; i < nums.Length - 2; i++) 
    {
        if (i == 0 || nums[i] != nums[i - 1]) 
        { // eliminate duplicates
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0) 
                {
                    result.Add(new List<int>{nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while (j < k && nums[j] == nums[j - 1]) j++; // eliminate duplicates
                    while (j < k && nums[k] == nums[k + 1]) k--; // eliminate duplicates
                } else if (sum < 0) 
                {
                    j++;
                } else 
                {
                    k--;
                }
            }
        }
    }

    return result.ToList<IList<int>>();
    }
}