
//经典的斐波那契数列！！！不理解就死记硬背吧
public class Solution 
{
    public int Fib(int n) 
    {
        if(n == 0)
        {
            return 0;
        }

        if(n == 1)
        {
            return 1;
        }

        return Fib(n - 1) + Fib(n - 2);
    }
}