//这道题要回头再看一遍。。。
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int[] answer = new int[temperatures.Length]; //返回的数组
        
        int[] index_container = new int[temperatures.Length];
        int j = -1; //如果j是负数，则index_container这个数组则关闭使用
        
    
    for(int i = 0; i < temperatures.Length; i++)  //遍历所给的数组
    {
        while(j > -1 && temperatures[i] > temperatures[index_container[j]]) //这个while会一直循环直到j小于零
        {
            int index = index_container[j--]; //index 可以为。（n+2), (n+1),(n)
            answer[index] = i - index;//这里answer[n+2] = n+2-(n+2).   [n+1] =n+2 -(n+1)   [n] = n+2 -n
        }
        index_container[++j] = i;// 提前++，要不然-1这个index没有办法先被赋值然后在++
        //如果接下来的1，2，3天都更冷。index_container 则为[0] = n, [1] = n+1, [2] = n+2
    }
    return answer;
    }
}