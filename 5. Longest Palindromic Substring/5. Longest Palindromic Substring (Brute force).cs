public class Solution
 {
    public string LongestPalindrome(string s)
    {
        if(s == null || s.Length < 1)
        {
            return "";
        }

        int start = 0;
        int end = 0;

        for(int i = 0; i < s.Length; i++)
        {
            int lenOdd = ExpandFromMiddle(s, i, i);
            int lenEven = ExpandFromMiddle(s, i, i + 1);
            int length = Math.Max(lenOdd, lenEven);

            if(length > end - start)
            {
                start = i - ((length - 1) / 2);
                end = i + (length / 2);
            }
        }

        return s.Substring(start, end - start + 1);
    
    }

     public int ExpandFromMiddle(string s, int left, int right)
        {
            if(s == null || left > right)
            {
                return 0;
            }

            while(left >= 0
               && right < s.Length
               && s[left] == s[right])
               {
                   left--;
                   right++;
               }

               return right - left - 1;
        }
}