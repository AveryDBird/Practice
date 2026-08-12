public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int slow =0;
        
        for(int fast = 1; fast < nums.Length; fast++)
        {
            if (nums[slow] == nums[slow+1])
            {
                nums[slow] *= 2;
                nums[slow+1] = 0;
                slow++;
            }
            else
            {
                slow ++;
            }
        }
        int insertPos = 0;
        //shift all zeros to end
        for(int zero = 0; zero < nums.Length; zero++)
        {
            if(nums[zero] !=0)
            {
                int inttempvalue = nums[insertPos];
                nums[insertPos] = nums[zero];
                nums[zero] = inttempvalue;
                
                insertPos ++;
            }
            
        }
        return nums;
    }
}