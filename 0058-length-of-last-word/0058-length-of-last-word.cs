public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] strS = s.Split(' ');
        return strS[^1].Length;
    }
}