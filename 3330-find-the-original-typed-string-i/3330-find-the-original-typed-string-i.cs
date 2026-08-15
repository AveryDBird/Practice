public class Solution {
    public int PossibleStringCount(string word) 
    {
        int intOutput = 1;
        string stated = "";
        foreach (char c in word)
        {
            if ( stated.Contains(c))
            {
                intOutput ++;
            }
            else
            {
            stated = "";
            stated += c;  
            }
        }
        return intOutput;
    }
}