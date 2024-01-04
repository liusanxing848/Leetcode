public class MyHashMap 
{
    int[] map;
    public MyHashMap() 
    {
        map = new int[1000001];
    }
    
    public void Put(int key, int value) 
    {
        map[key] = value + 1; //+1的原因是题目要求如果取不出来值就返回-1，那么所有没有赋值的元素的默认值都为0， 就算put进去val是0，加上1，也可以记录0的值的。非常巧妙
    }
    
    public int Get(int key) 
    {
        return map[key] - 1; //
    }
    
    public void Remove(int key) 
    {
        map[key] = 0;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */