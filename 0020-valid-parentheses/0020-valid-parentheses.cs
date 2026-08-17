public class Solution {
    public bool IsValid(string s) {
        while(s.Contains("()") ||s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "");
            s = s.Replace("[]", "");
            s = s.Replace("{}", "");
        }
        if(s.Length ==0)
        {
            return true;
        }
        else
        {
            return false;
        }  
    }
}