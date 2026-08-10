public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string strOutput = "";
        string shortest = strs[0];
        //find shortest word 
        foreach( string s in strs)
        {
            if (s.Length< shortest.Length)
            {
                shortest = s;
            }

        }
        //
        
        for ( int j = 0; j < shortest.Length; j++)
        {
           Char charLetter = shortest[j]; 
           foreach (string word in strs)
           {
            if (word[j] !=charLetter)
            {
                return strOutput;
                break;
            }
           }
           strOutput += charLetter;

        }
        
    
        return strOutput;
    }
}