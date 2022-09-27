public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        int i = digits.Length - 1;
        while(i >= 0)
        {
            if(digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
            i--;
        }
        int[] res = new int[digits.Length + 1];
        res[0] = 1;
        return res;
        
    }
}