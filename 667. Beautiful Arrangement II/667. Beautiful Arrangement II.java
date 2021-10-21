class Solution {
    public int[] constructArray(int n, int k) {
        int[] answer = new int[n];//declare返回数组,返回数组长度等于n
        
        int elementPosition = 0;
        //n-k之前则为1，2，3，4这样的规律。
        for (int value = 1; value < n-k; value++) {
            answer[elementPosition++] = value;//编织1，2，3，4，5。。。
        }
        
        //n-k之前的数列已经处理好了。现在处理之后剩下的，elementPosition因为上面的loop告诉这个loop从哪开始继续制作数组
        for (int i = 0; i <= k; i++) {//i<k 是因为还剩下k个元素没有处理，那么这个loop就处理k遍
            
            answer[elementPosition++] = (i%2 == 0) ? (n-k + i/2) : (n - i/2); //不懂，要重新看
        }
        return answer;
    }
}
