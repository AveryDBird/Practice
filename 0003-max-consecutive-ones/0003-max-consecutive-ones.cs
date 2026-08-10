public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int intMax = 0;
        int intOnes = 0;
        foreach (int num in nums)
        {
            if (num == 1)
            {
                intOnes ++;
            }
            else
            {
                intOnes = 0;
            }
            if (intOnes > intMax)
            {
                intMax = intOnes;
            }

        }
        return intMax;

    }
}