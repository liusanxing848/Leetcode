    // 暴力法 ----------------------------------------------------------------------------------------
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {

            //思路：利用两个指针，A: 1~n 
            //                 B: 1~n
            //                 C: 1~n
            //如此遍历整个数组。两个指针遍历为for loop 套 for loop。 这样两个指针可以把整个数组所有元素排列组合都照顾到
            //时间为nxn
            //若发现两个指针指向的元素纸只和正好为目标数字，则记录指针的位置，把指针位置的值赋给arr，最后输出arr。

            
            int[] arr = new int[2]; //因为题目要求返回两个数，arr为返回的数组。
            

            for (int i = 0; i < nums.Length; i++) //指针1， 最外层的for loop
            {
                int first = nums[i]; //指针1 的值
                
                for (int j = i + 1; j < nums.Length; j++) //指针2，第二层的for loop
                {
                    int second = nums[j]; //指针2 的值
                    
                    if ((first + second) == target)  //当，当下指针所指向的数组元素之和等于目标值
                    {
                        arr[0] = i; //最后出处答案数组的值1
                        arr[1] = j; //最后出处答案数组的值2
                        break; //找到则提前结束
                    }
                }   
            }  
            return arr; //最终输出答案
        }
    }
    

    //2  using Dictionary
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            int val = target - nums[i];
            if (map.ContainsKey(val)) 
            {
                return new int[] { map[val], i };
            }
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}