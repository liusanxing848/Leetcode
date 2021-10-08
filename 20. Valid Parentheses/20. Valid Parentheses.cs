public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> S = new Stack<char>(); //此题逻辑的用到的container
        
        bool answer = true; //初始化返回答案
        
        for (int i = 0; i < s.Length; i++) //遍历input的每一个char
        {
            switch(s[i]) //利用switch的方法来接住每一个case
            {
                case '(':  //情况1: 左开 (
                    
                case '[':  //情况2: 左开 [
                    
                case '{':  //情况3: 左开 {
                    
                    S.Push(s[i]);  //遍历整个string, 如果发现任何一个最开的情况,就把其放到stack里面
                    break; //找到后则结束上面三种case的筛选,继续遍历,这样会把所有的左开全部收到stack里面
                    
                    
                    
                    //=================== 运行到现在input里面不会有左开的情况 ======= 而Stack里面全是左开的char========
                    
                case ')':  //情况A:  右闭 )
                    if(S.Count > 0 && S.Pop() == '(' ) //pop一个stack里面的char看看能不能match 右开的情况
                    {
                        answer = true;
                        break; //若真的match上了,会到循环开始继续遍历下一个元素
                    }
                    else
                    {
                        answer = false;
                        break;
                    }
                    
                case '}': // 情况A:  右闭 }
                    if(S.Count > 0 && S.Pop() == '{' ) //pop一个stack里面的char看看能不能match 右开的情况
                    {
                        answer = true;
                        break; //若真的match上了,会到循环开始继续遍历下一个元素
                    }
                     else
                    {
                        answer = false;
                        break;
                    }
                    
                case ']': // 情况A:  右闭 ]
                    if(S.Count > 0 && S.Pop() == '[' ) //pop一个stack里面的char看看能不能match 右开的情况
                    {
                        answer = true;
                        break; //若真的match上了,会到循环开始继续遍历下一个元素
                    }
                     else
                    {
                        answer = false;
                        break;
                    }
                        
                default:
                    break; //switch 的套路   
            }
            
            if(answer == false)
            {
                break; //当配对发生不匹配的情况就没有必要再继续循环看了. 不废话直接跳出for loop.
                //这里不匹配的情况是暂不说是否每一个左右括号数量相等,而是像 [{]} 这种情况
            }
                     
        }
        
        if(answer == true && S.Count == 0) //这里封杀最后一种情况,虽然所有的match的都过了, 但是有很多没有参与match的 括号残留在stack 里面
        {
            return true;
        }
        else
        {
            return false;
        }        
    }
}