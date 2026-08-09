public class Solution {
    public int RomanToInt(string s) {
        //declare variables 
        int intInteger = 0;
        char[] symbols = ['I','V','X','L','C','D','M'];
        int[] values = [1,5,10,50,100,500,1000];

        int[] subtract = [1,10,100];
        int[] baseSubtract =[5,10,50,100,500,1000];

        //s is variable for string input
        int intRomanLength = s.Length;
        for ( int i =0; i< intRomanLength; i++)
        {
            char strCurrentChar = s[i];
            int intposition = Array.IndexOf(symbols,strCurrentChar);
            int intValue = values[intposition];
            if (i+1 < intRomanLength)
            {
                char charNextChar = s[i+1];
                int intNextPosition = Array.IndexOf(symbols,charNextChar);
                int intNextValue = values[intNextPosition];

                if ( subtract.Contains(intValue) && intValue< intNextValue )
                {
                    intInteger += (intNextValue-intValue);
                    i++;
                    
                }
                 else
                {
                    intInteger+= intValue;
                }

            }
            else
            {
                intInteger+= intValue;
            }
        }
        return intInteger;
    }
}