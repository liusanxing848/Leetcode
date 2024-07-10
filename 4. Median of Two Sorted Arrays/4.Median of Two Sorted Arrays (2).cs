public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int[] sumsum = new int[nums1.Length + nums2.Length];

        Array.Copy(nums1, 0, sumsum, 0, nums1.Length);
        Array.Copy(nums2, 0, sumsum, nums1.Length, nums2.Length);
        Array.Sort(sumsum);

        if (sumsum.Length % 2 == 0) 
        {
            return (double)(sumsum[sumsum.Length/2 - 1] + sumsum[sumsum.Length/2]) / 2.0;
        }
        return (double)sumsum[sumsum.Length/2];
    }
}