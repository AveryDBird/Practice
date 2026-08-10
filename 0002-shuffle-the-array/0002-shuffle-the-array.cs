public class Solution {
    public int[] Shuffle(int[] nums, int n) 
    {
        int intRange = nums.Length - n;
        int[] Output = new int[nums.Length];

        for(int i =0; i< n; i++)
        {
            Output[2* i] = nums[i];
            Output[2*i+1] = nums[i+n];
        }
        return Output;
    }
}