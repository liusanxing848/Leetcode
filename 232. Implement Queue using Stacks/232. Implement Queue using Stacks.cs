public class MyQueue 
{
    public Stack<int> Main_storage = null;
    public Stack<int> Aux_storage = null;

    public MyQueue() //ctor
    {
        Main_storage = new Stack<int>();
        Aux_storage = new Stack<int>();
    }
    
    public void Push(int x) 
    {
        Main_storage.Push(x);
    }
    
    public int Pop() 
    {
        if(Empty())
        {
            return -99999;
        }
        
        while(Main_storage.Count > 0)
        {
            Aux_storage.Push(Main_storage.Pop());//Main吐出来的全部叠到Aux里面，这样Main里面的元素顺序可以颠倒过来
        }
            
            int poped_answer = Aux_storage.Pop();//因为main最底下的元素变成了aux最上面的，把这个元素从aux中pop出来就达到了‘pop'出来main最底下的元素，整体来看是一个queue
            
        
        while (Aux_storage.Count > 0)
        {
            Main_storage.Push(Aux_storage.Pop() ); //佯装的dequeue之后还要把元素们原封不动的倒回到main里面，准备下一轮的pop
                
        }
            
            return poped_answer;
            
        
    }
    
    
    public int Peek() //    Peek 跟pop一模一样的模版
    {
        if(Empty())
        {
            return -99999;
        }
        
        while(Main_storage.Count > 0)
        {
            Aux_storage.Push(Main_storage.Pop());
        }
            
            int peeked_answer = Aux_storage.Peek();
            
        
        while (Aux_storage.Count > 0)
        {
            Main_storage.Push(Aux_storage.Pop() ); 
                
        }
            
            return peeked_answer;
            
    }
    
    public bool Empty()
    {
        if (Main_storage.Count == 0)
        {
            return true;
        }
        
        else return false;
    
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */