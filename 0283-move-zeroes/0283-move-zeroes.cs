public class Solution {
    public void MoveZeroes(int[] nums) {
        int intPosition = 0;
        for (int i =0; i<nums.Length;i++)
        {
            if(nums[i] != 0)
            {
                int intTempValue = nums[intPosition];
                nums[intPosition] = nums[i];
                nums[i] = intTempValue;
                intPosition++;
            }
        }
        return ;
    }
}