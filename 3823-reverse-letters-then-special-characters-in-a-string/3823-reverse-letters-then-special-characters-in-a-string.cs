public class Solution {
    public string ReverseByType(string s) {
       char[] charArray = s.ToCharArray();
       int left = 0;
       int right = charArray.Length -1;
       int left1 =0;
       int right1 = charArray.Length -1;
       while(left<right) 
       {
        if(!char.IsLetter(charArray[left]))
        {
            left++;
        }
        else if(!char.IsLetter(charArray[right]))
        {
            right--;
        }
        else
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;right --;
        }
       }
       while( left >= right && left1<right1)
       {
        if(char.IsLetter(charArray[left1]))
        {
            left1++;
        }
        else if (char.IsLetter(charArray[right1]))
        {
            right1--;
        }
        else
        {
           char temp1 = charArray[left1];
            charArray[left1]= charArray[right1];
            charArray[right1] = temp1;
            left1++;right1 --; 
        }
       }
       return new string(charArray);
    }
}