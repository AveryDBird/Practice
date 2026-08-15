public class Solution {
    public string FinalString(string s) {
        char[] charS = s.ToCharArray();
        List<char> charOutput = new List<char>();
        foreach(char c in s)
        {
            if (c != 'i')
            {
                charOutput.Add(c);
            }
            else
            {
                //reverse order
                charOutput.Reverse();
            }
        }
       return new string(charOutput.ToArray());
    }
}