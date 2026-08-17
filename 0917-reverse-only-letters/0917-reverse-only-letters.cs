public class Solution {
    public string ReverseOnlyLetters(string s) {
        char[] charS = s.ToCharArray();

        //point 
        int left = 0;
        int right = charS.Length -1;

     while(left<right)
     {
        if (!char.IsLetter(charS[left]))
        {
           left++;
        }
        else if(!char.IsLetter(charS[right]))
        {
            right--;
        }
        else{
            char temp = charS[left];
            charS[left] = charS[right];
            charS[right] = temp;
            left++;
            right--;
        }
     }
     return new string(charS);   
    }
}