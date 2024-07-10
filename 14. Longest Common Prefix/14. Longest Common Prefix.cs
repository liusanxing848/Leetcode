public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if(strs.Length == 1)
        {
            return strs[0];
        }

        string prefixString = "";

        if(strs == null || strs.Length == 0)
        {
            return prefixString;
        }

        for(int i = 0; i < strs[0].Length; i++) //go through first string
        {
            foreach(string s in strs)
            {
                if(i > s.Length - 1)
                {
                    return prefixString;
                }
                if(strs[0][i] != s[i])
                {
                    return prefixString;
                }
            }
            prefixString += strs[0][i];
        }
        return prefixString;
    }
}