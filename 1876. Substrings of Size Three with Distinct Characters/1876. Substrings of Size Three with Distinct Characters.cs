public class Solution 
{
    public int CountGoodSubstrings(string s) 
    {
        int count = 0;
        for(int i = 0; i < s.Length - 2; i ++)
        {
            string subString = s.Substring(i, 3);
            if(subString.Distinct().Count() == 3)
            {
                count++;
            }
        }
        return count;
    }
}