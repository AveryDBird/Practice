public class Solution {
    public int PossibleStringCount(string word) 
    {
        int intOutput = 1;
        char stated = '\0';
        foreach (char c in word)
        {
            if ( stated == c)
            {
                intOutput ++;
            }
            else
            {
            stated = c;  
            }
        }
        return intOutput;
    }
}