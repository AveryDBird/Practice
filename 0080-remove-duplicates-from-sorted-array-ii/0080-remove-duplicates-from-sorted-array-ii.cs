public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int slow =2;
        if (nums.Length <=2)
        {
            return nums.Length;
        }
        for(int fast = 2; fast<nums.Length;fast++) 
        {
            if( nums[fast] != nums[slow-2])
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }
        return slow;
    }
}