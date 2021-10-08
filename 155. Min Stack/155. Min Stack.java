//思路:
//这道题将stack所储存的数据结构编程tuple或者是有两个元素的数组.
//使用两个元素的数组:
//第一个元素{0}代表这真实数据,而第二个元素{1}则代表着当下最小的值
//每一次push的时候0号为无论如何都不变,而1号位则取当下步骤push的数字和当前最小值作比较的更小值.如果当下push进去的值成为了最小,则覆盖1号为位置.然后这个数组被完全push到stack里面
//pop操作则正常删除最上面的数组.如果不是最小值,整个stack会仍旧储存最小值.如果删除的是最小值,下一个元素会记录着下一个最小值.
//top的操作则相似为peep,这里其实是题目的一个提示,既然不能用peep,肯定是一个对数据特殊的储存方式.
//get min则返回最上面数组的1号位置的数字.因为最上面的数组1号位永远储存着当下的最小值





public class MinStack 
{
    
    private Stack<int[]> MyStack = new Stack<>();  //当call这个MinStack则创建一个新的stack,只不过里面的内容储存的是数组

    public MinStack()
    {
        //ctor
    }
        
    
    
    public void push(int val) 
    {
        //initialize第一个数组,如果stack是空的,需要初始化,这样下一个push会有可比性
        if(MyStack.isEmpty())
        {
            MyStack.push(new int[]{val, val}); //每次push都要new一个数组
            return; //一个空的stack添加后这个method就可以不用再往下运行了. 结束method, 初始化完毕
        }
        
        int cur_Min = MyStack.peek()[1]; //每一个最上面数组的第1号位都是最小值 (这一步只是取值,还没有开始push)
        
        if(val < cur_Min) //如果这个数值小于最小值(打破最小值记录了)
        {
            MyStack.push (new int[]{val, val});
        }
        else
        {
            MyStack.push (new int[]{val, cur_Min}); //如果挑战最小值失败,1号位还是当下最小值
        }
        
        
        
    }
    
    public void pop()
    {
        MyStack.pop(); //正常pop,不影响
    }
    
    public int top()
    {
        int top_Number = MyStack.peek()[0];//最上面的值是0号位的数字
        return top_Number;
    }
    
    public int getMin() 
    {
        int Minimum = MyStack.peek()[1]; //最小值为1号位
        return Minimum;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */