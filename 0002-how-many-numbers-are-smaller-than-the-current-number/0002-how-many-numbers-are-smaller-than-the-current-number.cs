public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] intSmallerOutput = new int[nums.Length];
        for(int i = 0; i< nums.Length; i++)
        {
            for (int j=0; j<nums.Length;j++)
            {
                if(nums[j] < nums[i])
                {
                    intSmallerOutput[i] +=1;
                }
            }
        }
        return intSmallerOutput;
    }
}