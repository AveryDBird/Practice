public class Solution {
    public int PossibleStringCount(string word) 
    {
        int intOutput = 1;
        string stated = "";
        foreach (char c in word)
        {
            //if duplicate add one
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