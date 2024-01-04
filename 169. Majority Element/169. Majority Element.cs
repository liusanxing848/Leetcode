public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int i in nums)
        {
            if(!dict.ContainsKey(i))
            {
                dict.Add(i, 1);
            }
            else
            {
                dict[i]++;
            }
        }

        KeyValuePair<int, int> pair = new KeyValuePair<int, int>(-1, -1);
        foreach(KeyValuePair<int, int> p in dict)
        {
            if(p.Value > pair.Value)
            {
                pair = p;
            }
        }

        return pair.Key;
    }
}