public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        string s = x.ToString();
        int i = 0; 
        int j = s.Length - 1;

        while(i < s.Length / 2)　//Use while. to control the halfway point.
        {
            if(s[i] != s[j])
            {
                return false;
            }
            
            i++;
            j--;
        }
        return true;
    }
}