public class Solution 
{
    public int Reverse(int x) 
    {

        string str = x.ToString();
        StringBuilder sb = new StringBuilder();
        int i = 0;
        int res;
        
        if(str[i] == '-')
        {
            i++;
            sb.Append("-");
        }
        
        for(int j = str.Length -1; j >= i; j--)
        {
            sb.Append(str[j]);
        }
        if(Int32.TryParse(sb.ToString(), out res))
        {
            return res;
        }
        return 0;
    }
}