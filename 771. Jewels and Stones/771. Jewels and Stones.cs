public class Solution 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        int jewelsCount = 0;
        HashSet<char> set = new HashSet<char>(jewels);
        foreach(char c in stones)
        {
            if(set.Contains(c))
            {
                jewelsCount ++;
            }
        }
        return jewelsCount;
    }
}