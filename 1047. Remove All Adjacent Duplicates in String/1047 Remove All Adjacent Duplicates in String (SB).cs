public class Solution
 {
    public string RemoveDuplicates(string s) 
    {
        StringBuilder sb = new StringBuilder();//用stringbuilder来做
        sb.Append(s[0]);//首先把第一个字符放进去

        for(int i = 1; i < s.Length; i++)//从第二个字母开始，因为第一个字母已经放到sb里面了
        {
            if(sb.Length > 0 && s[i] == sb[sb.Length - 1])//如果sb最新加进去的字母跟当下的字母一样。 并且sb不是空的时候， 
            {
                sb.Remove(sb.Length - 1, 1);//移除sb的最后一个，因为发现了重复字母
            }
            else
            {
                sb.Append(s[i]);//如果上面判断没有发现重复的字母，则把这个字母加进去。
            }
        }
        return sb.ToString();//
    }
}