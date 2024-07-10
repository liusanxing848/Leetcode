public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        int ans = 0;
        bool foundWord = false;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] != ' ')
            {
                foundWord = true;
                ans++;
                continue;
            }

            else if(foundWord) //if already found a word. then don't run the loop again.
            {
                break;
            }
        }
        return ans;
    }
}