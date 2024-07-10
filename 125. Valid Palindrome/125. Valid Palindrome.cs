public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        // Convert the string to lower case and remove non-alphanumeric characters
        s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        int i = 0;
        int j = s.Length - 1;
        
        // Use two-pointer technique to check for palindrome
        while (i < j) 
        {
            // If characters at i and j are not equal, return false
            if (s[i] != s[j]) 
            {
                return false;
            }
            i++;
            j--;
        }
        
        // If all characters match, return true
        return true;
    }
}
