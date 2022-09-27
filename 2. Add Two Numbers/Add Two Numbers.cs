/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

 /**思路**
 * 数据结构要用queue，题目说明链表储存的数字为反转顺序，也就是说链表头为数字的个位数。那么两个链表的头相加则为整数的个位相加
 * 先分别用queue把每一个链表的节点值储存下来，那么dequeue的时候从也是从链表的头开始，这样两个queue同时dequeue的时候就可以实现两个链表头为个位数相加，之后以此类推
 * 每当相加超过十的时候，十位记号则记录下来，相加的总和在被其余除10值覆盖，余除的目的是抹去十位
 * 若两个链表长短不一，多出来的链表部分则放到新的queue里面，再次进行相加即可。
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        //如果两个链表任意一个为空，则返回不为空的链表。因为没有什么可以相加的
        if(l1 == null) {return l2;}
        if(l2 == null) {return l1;}
        
        ListNode finger = new ListNode(); //finger为动态向下移动的指针
        ListNode dummy = new ListNode(); // dummy则为pin住finger起始位置，为最后返回值准备
        dummy = finger; //二者在创建在同一点（同一起跑线）
        
        Queue<int> q1 = new Queue<int>(); //新建两个queue
        Queue<int> q2 = new Queue<int>();
        int tenthIndicator = 0; //新建十位数记号
        
        while(l1 != null) //把链表1统统倒入queue里面
        {
            q1.Enqueue(l1.val);
            l1 = l1.next;
        }
        while(l2 != null)//链表2统统倒入queue里面
        {
            q2.Enqueue(l2.val);
            l2 = l2.next;
        }
        
        //加法逻辑
        while(q1.Count != 0 && q2.Count != 0) //循环里面会把两个queue储存的值吐出，当一个queue吐光了则停止循环。那时候要处理较长的链表
        {
            int sum = q1.Dequeue() + q2.Dequeue() + tenthIndicator;//求和为两个数字的值加上十位记号，如果上一位是大于10的，当下位数要被进一
            tenthIndicator = sum / 10; //每一次的合都要检验是否超过十，超过十这里的运算会让十位记号赋值，通常只会为1.
            sum %= 10; //求出的合要再创建新的节点，节点不能有大于10的值，所以，余除10来保留各位，抹去十位，没关系，上一行十位记号已经记录了如果合大于十的情况
            
            finger.next = new ListNode(sum); //finger的下一节点创造新的节点并且赋值。finger充当编制新的节点的“线头”
            finger = finger.next;//线头在编织好节点后向下移动，准备编制下一个节点
        }
        
        Queue<int> q3 = new Queue<int>();//创建新的queue来处理长短不一多出来的链表
        if(q1.Count != 0) //如果1号queue有剩余则转移1号queue
        {
            q3 = q1;
        }
        if(q2.Count != 0) //如果2号queue有剩余则转移2号queue
        {
            q3 = q2;
        }
        while(q3.Count != 0) //接下来要卸掉3号queue
        {
            int sum = q3.Dequeue() + tenthIndicator; //在上面的运算block里面，十位记号可能还带有值（最后一次计算大于10），单独dequeu的值就继续充当合
            tenthIndicator = sum/10; //这时候十位记号不可能大于0，因为剩下的都是个位数
            sum %= 10;
            finger.next = new ListNode(sum);
            finger = finger.next;
        }
        
        if(tenthIndicator != 0) //如果十位部位零，在此情况下两个链表长度为一样长度
        {
            finger.next = new ListNode(tenthIndicator);
            
        }
        
        return dummy.next;
    }
}