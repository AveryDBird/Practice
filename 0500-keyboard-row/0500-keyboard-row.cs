public class Solution {
    public string[] FindWords(string[] words) {
      List<string> lisOutput = new List<string>();
      string[] rows = ["qwertyuiopQWERTYUIOP","asdfghjklASDFGHJKL","zxcvbnmZXCVBNM"];
      foreach(string word in words)
      {
        int rowNum = Array.FindIndex(rows, row => row.Contains(word[0]));
        foreach ( char c in word)
        {
            if(word.All(c=> rows[rowNum].Contains(c)))
            {
                lisOutput.Add(word);
                break;
            }
        }
      }
      return lisOutput.ToArray();  
    }
}