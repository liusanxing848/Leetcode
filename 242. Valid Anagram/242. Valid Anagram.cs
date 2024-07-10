public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        char[] charArrS = s.ToCharArray(); //先变换成char array
        char[] charArrT = t.ToCharArray();

        Array.Sort(charArrS); //从小到大排列
        Array.Sort(charArrT);

        if(new string(charArrS) == new string(charArrT)) //在用这种new string的方法进行对比，不知道为什么toString不好用
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}

//solution 2
public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        string newS = new string(s.ToCharArray().OrderBy(c => c).ToArray());
        string newT = new string(t.ToCharArray().OrderBy(c => c).ToArray());
        return newS == newT;
    }
}