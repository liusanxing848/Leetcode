public class Solution 
{

    //"You would like to minimize the sum of the prices of the two chocolates you buy."
    public int BuyChoco(int[] prices, int money) 
    {
        Array.Sort(prices); //in order to find the minimum, first need to sort the array.
        int min = prices[0] + prices[1];
        if(money >= min)
        {
            return money - min;
        }
        else
        {
            return money;
        }
    }
}