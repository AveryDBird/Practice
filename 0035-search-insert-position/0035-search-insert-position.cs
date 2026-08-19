public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int right = nums.Length-1;
        int left = 0;
        while(left <=right)
        {
            int intMid = left + (right-left) /2;
            if(nums[intMid] == target)
            {
                return intMid;
            }
            else if (nums[intMid] < target)
            {
                left = intMid+1;
            }
            else if (nums[intMid] > target)
            {
                right = intMid-1;
            }
        }
        return left;
    }
}