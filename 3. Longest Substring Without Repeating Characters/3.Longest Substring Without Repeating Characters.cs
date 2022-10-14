public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        if(s == null || s.Length == 0)
        {
            return 0;
        }
        
        Dictionary<char, int> d = new Dictionary<char, int>();
        int left = 0;
        int max = 1; // max always equals, i - left + 1
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(d.ContainsKey(c))
            {
                left = Math.Max(left, d[c] + 1);//如果发现了重复，left指针就要移动到刚刚发现的重复char上面
                d.Remove(c);
            }
            
            if(i - left + 1 > max)
            {
                max = i - left + 1;
            }
            
            d.Add(c, i);

        }
        return max;
        
    }
}