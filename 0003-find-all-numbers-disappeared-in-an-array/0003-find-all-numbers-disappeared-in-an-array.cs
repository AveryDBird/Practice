public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> lisOutput = new List<int>();
        int[] intUsed = new int[nums.Length +1];

        for (int num = 0; num< nums.Length ;num++)
        {
            intUsed[nums[num]]++;
        }
        for (int i = 1; i< intUsed.Length ;i++)
        {
            if (intUsed[i] == 0)
            {
               lisOutput.Add(i);
            }
        }
        return lisOutput;

    }
}