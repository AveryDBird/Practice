public class Solution {
    public string[] FindWords(string[] words) {
      List<string> lisOutput = new List<string>();
      string[] rows = ["qwertyuiopQWERTYUIOP","asdfghjklASDFGHJKL","zxcvbnmZXCVBNM"];
      //then see the row required from the first letter
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
            else
            {
                continue;
            }
            
        }
      }
      return lisOutput.ToArray();
      //go through the word to see if everything on same row (if so add to soultions)  
    }
}