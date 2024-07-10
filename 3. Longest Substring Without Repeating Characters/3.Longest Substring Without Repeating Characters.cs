public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        if(s == null || s.Length == 0)
        {
            return 0;
        }

        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0;
        int max = 1; //max always equals, i - left + 1

        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            
            if(dict.ContainsKey(c))
            {
                left = Math.Max(left, dict[c] + 1);
                dict.Remove(c);
            }

            if( i - left + 1> max)
            {
                max = i - left + 1;
            }

            dict.Add(c, i);
        }
        return max;
    }

}