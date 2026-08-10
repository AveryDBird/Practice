public class Solution {
    public int[] FindErrorNums(int[] nums) {
        //output repeated , missing number
        //int intStart = 1;
        int[] ans = new int[2];
        int[] intUsed = new int[nums.Length +1];


        for (int num = 0; num< nums.Length ;num++)
        {
            intUsed[nums[num]]++;
        }
        for (int i = 1; i< intUsed.Length ;i++)
        {
            if (intUsed[i] == 2)
            {
                ans[0] = i;
            }
            if (intUsed[i] == 0)
            {
                ans[1] = i;
            }
        }
        

        return ans;
    }
}