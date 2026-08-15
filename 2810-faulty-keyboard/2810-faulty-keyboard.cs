public class Solution {
    public string FinalString(string s) {
        List<char> charOutput = new List<char>();
        foreach(char c in s)
        {
            if (c != 'i')
            {
                charOutput.Add(c);
            }
            else
            {
                charOutput.Reverse();
            }
        }
       return new string(charOutput.ToArray());
    }
}