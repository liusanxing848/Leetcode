public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int[] arr = new int[257];
        int left = 0;
        int right = 0;
        int ans = 0;
        while (left <= right && left < s.Length)
        {
            while (right < s.Length)
            {
                if (arr[s[right]] == 0)
                {
                    arr[s[right]]++;
                    right++;
                }
                else
                {
                    break;
                }
            }

            ans=Math.Max(right - left , ans);
            arr[s[left]]--;
            left++;
        }
        return ans;
    }
}