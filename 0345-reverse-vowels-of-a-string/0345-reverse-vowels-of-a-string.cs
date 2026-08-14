public class Solution {
    public string ReverseVowels(string s) {
        char[] arr = s.ToCharArray();
        int i = 0;
        int right = s.Length-1;
        string strVowels = "aeiouAEIOU";
        while(i<right)
        {
            if(strVowels.Contains(arr[i]) && strVowels.Contains(arr[right]))
            {
                char temp = arr[i];
                arr[i] = arr[right];
                arr[right] = temp;
                right --;
                i ++;
            }
            else if (strVowels.Contains(arr[i]))
            {
                right--;
            }
            else
            {
                i ++;
            }
        }
        return new string(arr);
    }
}