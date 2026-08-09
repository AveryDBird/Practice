public class Solution {
    public bool IsPalindrome(int x) {
      if (x >= 0 )  
      {
        string strX = x.ToString();
        Char[] charArray = strX.ToCharArray();
        Array.Reverse(charArray);
        string strReverse = new string(charArray);
        if (strX == strReverse)
        {
            return true;
        }
        else
        {
            return false;
        }

      }
      else
      {
        return false;
      }
    }
}