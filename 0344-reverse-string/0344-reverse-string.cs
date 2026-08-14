public class Solution {
    public void ReverseString(char[] s) {
        int right = s.Length-1;
        for ( int i =0; i< right ;i++)
        {
            char temp = s[i];
            s[i] = s[right];
            s[right] = temp;
            right --;
        }
       
    }
}