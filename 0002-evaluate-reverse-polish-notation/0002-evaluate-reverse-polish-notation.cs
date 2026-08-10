public class Solution {
    public int EvalRPN(string[] tokens) {
        int ans = 0;
        List<int> lisNum = new List<int>();

        for(int tok =0; tok< tokens.Length; tok++)
        {
            if(tokens[tok] != "+" && tokens[tok] != "-" && tokens[tok] != "*" && tokens[tok] != "/" )
            {
                
                lisNum.Add(int.Parse(tokens[tok]));
            }
            else
            {
                int intTempTotal = 0;

                switch(tokens[tok])
                {
                    case "+":
                        intTempTotal = lisNum[^2] + lisNum[^1];
                        break;
                    case "-":
                        intTempTotal = lisNum[^2] - lisNum[^1];
                        break;
                    case "/":
                        intTempTotal = lisNum[^2] / lisNum[^1];
                        break;
                    case "*":
                        intTempTotal = lisNum[^2] * lisNum[^1];
                        break;
                }
                
                lisNum.RemoveRange(lisNum.Count -2,2);
                lisNum.Add(intTempTotal);
            }
        }
        ans = lisNum[0];
        return ans;
    }
}